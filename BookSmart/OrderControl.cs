namespace BookSmart;
using System;
using System.Linq;
using System.Windows.Forms;
using BookSmart.Services;
public partial class OrderControl : UserControl
{
    private readonly RentalService _rentalService = new();

    public OrderControl()
    {
        InitializeComponent();
    }

    private async void OrdersControl_Load(object sender, EventArgs e)
    {
        var rentals = await _rentalService.LoadRentalsAsync();
        dataGridRentals.DataSource = rentals;
    }

    private void label1_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}