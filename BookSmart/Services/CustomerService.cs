using BookSmart.Models;

namespace BookSmart.Services;

public class CustomerService
{
    private readonly string _customersFile = Path.Combine(ConfigService.Config.DataFolder, "customers.txt");

    public CustomerService()
    {
        Directory.CreateDirectory(Path.GetDirectoryName(_customersFile)!); // ensure data folder exists
    }

    // add a new customer
    public async Task AddCustomerAsync(Customer customer)
    {
        var customers = await LoadCustomersAsync();
        customer.CustomerID = GenerateCustomerId(customers);
        customers.Add(customer);
        await SaveCustomersAsync(customers);
    }

    // get customer by name
    public async Task<Customer?> GetCustomerByNameAsync(string name)
    {
        var customers = await LoadCustomersAsync();
        return customers.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    // get all customers
    public async Task<List<Customer>> GetAllCustomersAsync()
    {
        return await LoadCustomersAsync();
    }

    // load customers from file
    private async Task<List<Customer>> LoadCustomersAsync()
    {
        if (!File.Exists(_customersFile))
            return new List<Customer>();

        var lines = await File.ReadAllLinesAsync(_customersFile);
        var list = new List<Customer>();

        foreach (var line in lines.Select(l => l.Trim()).Where(l => !string.IsNullOrEmpty(l)))
        {
            var parts = line.Split('|');
            if (parts.Length >= 3)
            {
                list.Add(new Customer
                {
                    CustomerID = int.Parse(parts[0]),
                    Name = parts[1],
                    Email = parts[2],
                    Phone = parts.Length > 3 ? parts[3] : ""
                });
            }
        }

        return list;
    }

    // save customers to file
    private async Task SaveCustomersAsync(List<Customer> customers)
    {
        var lines = customers.Select(c =>
            $"{c.CustomerID}|{c.Name}|{c.Email}|{c.Phone}");
        await File.WriteAllLinesAsync(_customersFile, lines);
    }

    // generate unique CustomerId
    private int GenerateCustomerId(List<Customer> customers)
    {
        return customers.Count == 0 ? 1 : customers.Max(c => c.CustomerID) + 1;
    }
}
