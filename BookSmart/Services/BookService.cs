using BookSmart.Models;

namespace BookSmart.Services;

public class BookService
{
    // get book by Id
    public async Task<Book?> GetBookByIdAsync(int bookId)
    {
        var books = await FileStore.LoadBooksAsync();
        return books.FirstOrDefault(b => b.BookId == bookId);
    }

    // get book by title
    public async Task<Book?> GetBookByTitleAsync(string title)
    {
        var books = await FileStore.LoadBooksAsync();
        return books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    // search books by partial match in title or author
    public async Task<List<Book>> SearchBooksAsync(string query)
    {
        var books = await FileStore.LoadBooksAsync();
        query = query.ToLower();
        return books.Where(b =>
            b.Title.ToLower().Contains(query) || b.Author.ToLower().Contains(query))
            .ToList();
    }

    // check availability by ID
    public async Task<bool> IsBookAvailableAsync(int bookId)
    {
        var book = await GetBookByIdAsync(bookId);
        return book != null && book.Quantity > 0;
    }

    // add a new book
    public async Task AddBookAsync(Book book)
    {
        var books = await FileStore.LoadBooksAsync();
        books.Add(book);
        await FileStore.SaveBooksAsync(books);
    }

    // update quantity of a book
    public async Task<bool> UpdateBookQuantityAsync(int bookId, int change)
    {
        var books = await FileStore.LoadBooksAsync();
        var book = books.FirstOrDefault(b => b.BookId == bookId);
        if (book == null) return false;

        book.Quantity += change;
        if (book.Quantity < 0) book.Quantity = 0; // prevent negative stock

        await FileStore.SaveBooksAsync(books);
        return true;
    }

    // get all books
    public async Task<List<Book>> GetAllBooksAsync()
    {
        return await FileStore.LoadBooksAsync();
    }
}
