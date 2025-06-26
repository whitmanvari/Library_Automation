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
    public partial class BookList : Form
    {
        int CategoryId;
        string Name;
        int Id;
        LibraryContext context = new LibraryContext();
        public BookList(string text, Category category, int Id)
        {
            InitializeComponent();
            Name = text;
            CategoryId = category.Id;
            this.Id = Id;
           
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet6.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryAutomationDataSet6.Books);
            var books = context.Books.Where(b => b.CategoryId == CategoryId).ToList();
            if (books.Count == 0)
            {
                MessageBox.Show("There are no records like this!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView_booklist.DataSource = books;

        }

      

        private void label1_Click(object sender, EventArgs e)
        {
            Member_MainMenu member_Main = new Member_MainMenu(Name,Id);
            member_Main.Show();
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
