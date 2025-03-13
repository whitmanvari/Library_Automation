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

        private void comboBox_categoriesOther_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the selected category id from the combobox.
            int selectedCategoryId = Convert.ToInt32(comboBox_categoriesOther.SelectedValue);

            var books = context.Books
                .Where(b=> b.CategoryId==selectedCategoryId)
                .ToList(); //get books from database where the category id is equal to the selected category id.

            //if there are no books in the list, show the Empty error message..
            if (books.Count == 0)
            {
                MessageBox.Show("There are no records of this book!", "Empty!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void Admin_Book_Category_Load(object sender, EventArgs e)
        {
            //get categories from database and put them in a new list named categories.
            var categories = context.Categories.ToList();

            comboBox_categoriesOther.DataSource = categories;

            //this area will be displayed in the combobox.
            comboBox_categoriesOther.DisplayMember = "Name"; 
            comboBox_categoriesOther.ValueMember = "Id";
        }
    }
}

