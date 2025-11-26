namespace BookSmart;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        // Setup clock timer
        timer1.Interval = 1000; 
        timer1.Tick += timer1_Tick;
        timer1.Start();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        lblClock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    private void timer1_Tick(object? sender, EventArgs e)
    {
        lblClock.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }
    
    private void LoadControl(UserControl control)
    {
        panelMainCustomer.Controls.Clear();
        control.Dock = DockStyle.Fill;
        panelMainCustomer.Controls.Add(control);
    }

    private void buttonSearch_Click(object sender, EventArgs e)
    {
        LoadControl(new SearchControl());
    }

    private void buttonRent_Click(object sender, EventArgs e)
    {
        LoadControl(new RentControl());
    }

    private void buttonReturn_Click(object sender, EventArgs e)
    {
        LoadControl(new ReturnControl());
    }

    private void buttonOrders_Click(object sender, EventArgs e)
    {
        LoadControl(new OrderControl());
    }

    private void buttonAccount_Click(object sender, EventArgs e)
    {
        LoadControl(new AccountControl());
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}