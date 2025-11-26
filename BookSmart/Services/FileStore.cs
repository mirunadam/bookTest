using BookSmart.Models;

namespace BookSmart.Services;

public static class FileStore
{
    public static string DataFolder =>
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
    public static string BooksPath => Path.Combine(DataFolder, "books.txt");
    public static string RentalsPath => Path.Combine(DataFolder, "rentals.txt");
    public static string OrdersPath => Path.Combine(DataFolder, "orders.txt");
    
    public static async Task<List<Book>> LoadBooksAsync()
    {
        Directory.CreateDirectory(DataFolder);

        if (!File.Exists(BooksPath))
        {
            File.WriteAllText(BooksPath,
                "98|The Odyssey|Homer|19.99|700|3\n" +
                "99|To Kill a Mockingbird|Harper Lee|19.99|1960|1");
        }

        var lines = await File.ReadAllLinesAsync(BooksPath);
        var list = new List<Book>();

        foreach (var ln in lines.Select(l => l.Trim()).Where(l => !string.IsNullOrEmpty(l)))
        {
            var parts = ln.Split('|');
            if (parts.Length >= 6 && int.TryParse(parts[5], out var qty))
            {
                list.Add(new Book
                {
                    BookId = int.Parse(parts[0]),
                    Title = parts[1],
                    Author = parts[2],
                    Price = float.Parse(parts[3]),
                    Year = int.Parse(parts[4]),
                    Quantity = qty
                });
            }
        }

        return list;
    }

    public static async Task SaveBooksAsync(List<Book> books)
    {
        Directory.CreateDirectory(DataFolder);

        var lines = books.Select(b =>
            $"{b.BookId}|{b.Title}|{b.Author}|{b.Price}|{b.Year}|{b.Quantity}");
        await File.WriteAllLinesAsync(BooksPath, lines);
    }

}
