namespace BookSmart;
using System;
using System.Linq;
using System.Windows.Forms;
using BookSmart.Services;
using BookSmart.Models;
public partial class SearchControl : UserControl
{
    private readonly BookService _bookService = new();

    public SearchControl()
    {
        InitializeComponent();
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        string query = txtSearch.Text.Trim();
        if (query.Length < 1)
        {
            MessageBox.Show("Please enter a search term.");
            return;
        }

        var results = await _bookService.SearchBooksAsync(query);
        dataGridBooks.DataSource = results.ToList();
    }
}