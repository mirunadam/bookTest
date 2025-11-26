namespace BookSmart;
using System;
using System.Windows.Forms;
using BookSmart.Services;
public partial class RentControl : UserControl
{
    private readonly RentalService _rentalService = new();

    public RentControl()
    {
        InitializeComponent();
    }

    private async void btnRent_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtBookId.Text, out int bookId))
        {
            MessageBox.Show("Invalid Book ID");
            return;
        }

        string customer = txtCustomer.Text.Trim();
        if (customer.Length == 0)
        {
            MessageBox.Show("Enter customer name.");
            return;
        }

        var rental = await _rentalService.RentBookAsync(bookId, customer);

        if (rental == null)
        {
            MessageBox.Show("Book unavailable!");
            return;
        }

        MessageBox.Show($"Book rented successfully!\nRental ID: {rental.RentalId}");
    }
    
}