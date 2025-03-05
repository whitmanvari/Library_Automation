using Library.DataContext;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Model.Concrete;

namespace Library.View.Presentation
{
    public partial class Admin_Book_Category : Form
    {
        LibraryContext context = new LibraryContext();
        string Name;
        int Id;
        public Admin_Book_Category(string text, int id)
        {
            InitializeComponent();
            Name = text;
            Id = id;
        }

        private void label_gobackAdminMainMenu_Click(object sender, EventArgs e)
        {
            Admin_MainMenu admin_MainMenu = new Admin_MainMenu(Name, Id);
            admin_MainMenu.Show();
            this.Hide();
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button_scienceFiction_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Science Fiction"));

        }

        private void button_romance_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Romance"));

        }

        private void button_literaryFiction_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Literary Fiction"));

        }

        private void button_horror_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Horror"));

        }

        private void button_fantasy_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Fantasy"));
        }

        private void button_historicalFiction_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Historical Fiction"));
        }

        private void button_poetry_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Poetry"));
        }

        private void button_adventureFiction_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Adventure"));
        }

        private void button_Philosophy_Click(object sender, EventArgs e)
        {
           Show(ShowBooksByCategory("Philosophy"));
        }

        private void button_fairyTale_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Fairy Tale"));
        }

        private void button_dystopian_Click(object sender, EventArgs e)
        {
            Show(ShowBooksByCategory("Dystopian"));
        }

        private void button_biography_Click(object sender, EventArgs e)
        {

           Show(ShowBooksByCategory("Biography"));

        }
        public int ShowBooksByCategory(string categoryName)
        {
            var category = context.Categories.FirstOrDefault(c => c.Name == categoryName);
            if (category == null)
            {
                MessageBox.Show("There are no records of this category!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;

            } 
             return category.Id;

        }
        public void Show(int id)
        {
            Admin_Book_List admin_Book_List = new Admin_Book_List(Name, Id, id);
            admin_Book_List.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label_chooseAcategory.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label_chooseAcategory.Visible=false;
        }
    }
}

