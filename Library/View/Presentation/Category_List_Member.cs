using Library.DataContext;
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
    public partial class Category_List_Member : Form
    {
        string Name;
        int Id;
        
        public Category_List_Member(string text, int id)
        {
            InitializeComponent();
            Name = text;
            this.Id= id;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Member_MainMenu mainMenu = new Member_MainMenu(Name, Id);
            mainMenu.Show();
            this.Hide();

        }
        public void ShowBooksByCategory(string categoryName)
        { 
            LibraryContext libraryContext = new LibraryContext();
            var booksByCategoryId = libraryContext.Categories.FirstOrDefault(c => c.Name == categoryName);
            if (booksByCategoryId != null)
            {
                BookList bookList = new BookList(Name, booksByCategoryId, Id);
            }
            else
            {
                MessageBox.Show("Book List is empty!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_scienceFiction_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Science Fiction");
        }

        private void button_romance_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Romance");
        }

        private void button_literaryFiction_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Literary Fiction");
        }

        private void button_horror_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Horror");
        }

        private void button_fantasy_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Fantasy");
        }

        private void button_historicalFiction_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Historical Fiction");
        }

        private void button_poetry_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Poetry");
        }

        private void button_adventure_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Adventure");
        }

        private void button_philosophy_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Philosophy");
        }

        private void button_fairyTale_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Fairy Tale");
        }

        private void button_dystopian_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Dystopian");
        }

        private void button_biography_Click(object sender, EventArgs e)
        {
            ShowBooksByCategory("Biography");
        }
    }
}
