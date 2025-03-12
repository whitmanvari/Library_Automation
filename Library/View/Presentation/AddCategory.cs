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
    public partial class AddCategory : Form
    {
        string Name;
        int Id;
        LibraryContext _context = new LibraryContext();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button_approveCategory_Click(object sender, EventArgs e)
        {
            _context.Categories.Add(new Category
            {
                Name = textBox_addCategory.Text
            });
            _context.SaveChanges();
            MessageBox.Show("Category added successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Open categories list form
            Name = _context.Categories.FirstOrDefault(c => c.Name == textBox_addCategory.Text).ToString();
            Id = _context.Categories.FirstOrDefault(c => c.Name == textBox_addCategory.Text).Id;
            Admin_Book_Category admin_Book_Category = new Admin_Book_Category(Name, Id);
            admin_Book_Category.Show();
            this.Close();
        }

        private void label_goBack_Click(object sender, EventArgs e)
        {
            Admin_MainMenu admin_MainMenu = new Admin_MainMenu(Name, Id);
            admin_MainMenu.Show();
            this.Close();
        }
    }
}
