using Library.DataContext;
using Library.Model.Concrete;
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
    public partial class Admin_Book_List : Form
    {
        LibraryContext libraryContext = new LibraryContext();
        int CategoryId;
        string Name;
        int Id;

        public Admin_Book_List(string text, int id, int categoryId)
        {
            InitializeComponent();
            Name = text;
            Id = id;
            CategoryId = categoryId;
           
        }

        private void Admin_Book_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet9.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryAutomationDataSet9.Books);
            var books = libraryContext.Books.Where(b => b.CategoryId == CategoryId).ToList();
            if (books.Count == 0)
            {
                MessageBox.Show("There are no records like this!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = books;
        }
    
        private void label1_Click(object sender, EventArgs e)
        {
            Admin_Book_Category admin_Book_ = new Admin_Book_Category(Name, Id);
            admin_Book_.Show();
            this.Close();
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

    }
}
