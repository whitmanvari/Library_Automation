using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.View.Presentation
{
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryAutomationDataSet.Books);

        }

        private void label_signin_BookList_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
