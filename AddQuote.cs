using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Project
{

    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();

        }

        private void GetQuote_Click(object sender, EventArgs e)
        {
            DisplayQuote quote = new DisplayQuote();
            quote.ShowDialog();
            this.Close();

        }
    }
}
