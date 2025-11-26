using BookSmart.Models;

namespace BookSmart.Services;

public class OrderService
{
    private readonly string _ordersFile = FileStore.OrdersPath;

    public OrderService()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_ordersFile)!); // ensure data folder exists
    }

    // place new order
    public async Task<Order> PlaceOrderAsync(int bookId, string customerName, int estimatedDeliveryDays)
    {
        var orders = await LoadOrdersAsync();
        var order = new Order
        {
            OrderId = GenerateOrderId(orders),
            BookId = bookId,
            CustomerName = customerName,
            OrderedOn = DateTime.UtcNow,
            EstimatedDeliveryOn = DateTime.UtcNow.AddDays(estimatedDeliveryDays),
        };

        orders.Add(order);
        await SaveOrdersAsync(orders);

        return order;
    }

    // mark order as delivered
    public async Task<Order?> MarkAsDeliveredAsync(int orderId)
    {
        var orders = await LoadOrdersAsync();
        var order = orders.FirstOrDefault(o => o.OrderId == orderId);

        if (order == null || order.DeliveredOn != null)
            return null;

        order.DeliveredOn = DateTime.UtcNow;
        await SaveOrdersAsync(orders);
        return order;
    }

    // get all orders
    public async Task<List<Order>> GetAllOrdersAsync()
    {
        return await LoadOrdersAsync();
    }

    // load orders from file
    private async Task<List<Order>> LoadOrdersAsync()
    {
        if (!File.Exists(_ordersFile))
            return new List<Order>();

        var lines = await File.ReadAllLinesAsync(_ordersFile);
        var list = new List<Order>();

        foreach (var line in lines.Select(l => l.Trim()).Where(l => !string.IsNullOrEmpty(l)))
        {
            var parts = line.Split('|');
            if (parts.Length >= 5)
            {
                list.Add(new Order
                {
                    OrderId = int.Parse(parts[0]),
                    BookId = int.Parse(parts[1]),
                    CustomerName = parts[2],
                    OrderedOn = DateTime.Parse(parts[3]),
                    EstimatedDeliveryOn = DateTime.Parse(parts[4]),
                    DeliveredOn = parts.Length > 5 && !string.IsNullOrEmpty(parts[5]) ? DateTime.Parse(parts[5]) : null
                });
            }
        }

        return list;
    }

    // save orders to file
    private async Task SaveOrdersAsync(List<Order> orders)
    {
        var lines = orders.Select(o =>
            $"{o.OrderId}|{o.BookId}|{o.CustomerName}|{o.OrderedOn:O}|{o.EstimatedDeliveryOn:O}|{(o.DeliveredOn.HasValue ? o.DeliveredOn.Value.ToString("O") : "")}");
        await File.WriteAllLinesAsync(_ordersFile, lines);
    }

    //generate OrderId
    private int GenerateOrderId(List<Order> orders)
    {
        return orders.Count == 0 ? 1 : orders.Max(o => o.OrderId) + 1;
    }
}
