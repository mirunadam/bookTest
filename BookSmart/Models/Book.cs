namespace BookSmart.Models;

public class Book
{
    public int BookId{ get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    
    public float Price { get; set; }
    
    public int Year { get; set; }
    public int Quantity { get; set; }
}