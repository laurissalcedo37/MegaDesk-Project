namespace MegaDesk_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote aqx = new AddQuote();
            aqx.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes vaq = new ViewAllQuotes();
            vaq.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchQuotes sq = new SearchQuotes();
            sq.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}