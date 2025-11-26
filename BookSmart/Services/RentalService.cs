using BookSmart.Models;

namespace BookSmart.Services;

public class RentalService
{
    private readonly string _rentalsFile = FileStore.RentalsPath;
    
    public async Task<Rental?> RentBookAsync(int bookId, string customerName, int rentalDays = 0)
    {
        rentalDays = rentalDays > 0 ? rentalDays : ConfigService.Config.DefaultRentalDays;

        // load books
        var books = await FileStore.LoadBooksAsync();
        var book = books.FirstOrDefault(b => b.BookId == bookId);

        if (book == null || book.Quantity <= 0)
            return null; //book unavailable
        
        book.Quantity--; 
        await FileStore.SaveBooksAsync(books);

        // create rental
        var rental = new Rental
        {
            RentalId = GenerateRentalId(),
            BookId = book.BookId,
            CustomerName = customerName,
            RentedOn = DateTime.UtcNow,
            DueOn = DateTime.UtcNow.AddDays(rentalDays),
            ReturnedOn = null,
            Fee = 0
        };

        // persist rental
        var rentals = await LoadRentalsAsync();
        rentals.Add(rental);
        await SaveRentalsAsync(rentals);

        return rental;
    }

    // return a book
    public async Task<Rental?> ReturnBookAsync(int rentalId)
    {
        var rentals = await LoadRentalsAsync();
        var rental = rentals.FirstOrDefault(r => r.RentalId == rentalId);

        if (rental == null || rental.ReturnedOn != null)
            return null; // already returned or not found

        rental.ReturnedOn = DateTime.UtcNow;
        rental.Fee = CalculateFee(rental.DueOn, rental.ReturnedOn.Value);

        // update rentals file
        await SaveRentalsAsync(rentals);

        // increment book quantity
        var books = await FileStore.LoadBooksAsync();
        var book = books.FirstOrDefault(b => b.BookId == rental.BookId);
        if (book != null)
        {
            book.Quantity++;
            await FileStore.SaveBooksAsync(books);
        }

        return rental;
    }

    // calculate late fee
    public static double CalculateFee(DateTime dueUtc, DateTime returnedUtc)
    {
        var diffDays = Math.Ceiling((returnedUtc - dueUtc).TotalDays);
        return diffDays > 0 ? diffDays * ConfigService.Config.FeePerDay : 0;
    }

    // load rentals from file
    public async Task<List<Rental>> LoadRentalsAsync()
    {
        if (!File.Exists(_rentalsFile))
            return new List<Rental>();

        var lines = await File.ReadAllLinesAsync(_rentalsFile);
        var list = new List<Rental>();

        foreach (var line in lines.Select(l => l.Trim()).Where(l => !string.IsNullOrEmpty(l)))
        {
            var parts = line.Split('|');
            if (parts.Length >= 6)
            {
                list.Add(new Rental
                {
                    RentalId = int.Parse(parts[0]),
                    BookId = int.Parse(parts[1]),
                    CustomerName = parts[2],
                    RentedOn = DateTime.Parse(parts[3]),
                    DueOn = DateTime.Parse(parts[4]),
                    ReturnedOn = string.IsNullOrEmpty(parts[5]) ? null : DateTime.Parse(parts[5]),
                    Fee = parts.Length > 6 ? double.Parse(parts[6]) : 0
                });
            }
        }

        return list;
    }

    // save rentals to file
    public async Task SaveRentalsAsync(List<Rental> rentals)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_rentalsFile)!);
        var lines = rentals.Select(r =>
            $"{r.RentalId}|{r.BookId}|{r.CustomerName}|{r.RentedOn:O}|{r.DueOn:O}|{(r.ReturnedOn.HasValue ? r.ReturnedOn.Value.ToString("O") : "")}|{r.Fee}");
        await File.WriteAllLinesAsync(_rentalsFile, lines);
    }

    // rental Id generator
    private int GenerateRentalId()
    {
        var rentals = File.Exists(_rentalsFile) ? File.ReadAllLines(_rentalsFile).Length : 0;
        return rentals + 1;
    }
}
