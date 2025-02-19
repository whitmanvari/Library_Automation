using Library.DataContext;
using Library.Model.Concrete;
using Library.View.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form_Welcome : Form
    {
        LibraryContext libraryContext = new LibraryContext();
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Form_Welcome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
