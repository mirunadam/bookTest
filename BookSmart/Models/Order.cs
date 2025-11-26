namespace BookSmart.Models;

public class Order
{
    public int OrderId { get; set; }
    public int BookId { get; set; }
    public string Title { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderedOn { get; set; }
    public DateTime EstimatedDeliveryOn { get; set; }
    public DateTime? DeliveredOn { get; set; }
}