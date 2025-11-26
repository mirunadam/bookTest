namespace BookSmart;
using System;
using System.Windows.Forms;
using BookSmart.Services;
public partial class ReturnControl : UserControl
{
    private readonly RentalService _rentalService = new();

    public ReturnControl()
    {
        InitializeComponent();
    }

    private async void btnReturn_Click(object sender, EventArgs e)
    {
        if (!int.TryParse(txtRentalId.Text, out int rentalId))
        {
            MessageBox.Show("Invalid Rental ID");
            return;
        }

        var rental = await _rentalService.ReturnBookAsync(rentalId);

        if (rental == null)
        {
            MessageBox.Show("Rental not found or already returned.");
            return;
        }

        MessageBox.Show($"Book returned. Fee: {rental.Fee} RON");
    }
}