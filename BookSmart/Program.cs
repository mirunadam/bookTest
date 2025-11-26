namespace BookSmart
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}


//Enable book return and renewal functionality.
//Include a UI calendar control for selecting rental and return dates.
//Allow input of estimated delivery days. - should be random