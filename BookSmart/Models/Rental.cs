namespace BookSmart.Models;

public class Rental
{
    public int RentalId { get; set; }
    public int BookId { get; set; }
    public string CustomerName { get; set; }
    public DateTime RentedOn { get; set; }
    public DateTime DueOn { get; set; }
    public DateTime? ReturnedOn { get; set; }
    public double Fee { get; set; }
    
}