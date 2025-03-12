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
        LibraryContext _context = new LibraryContext();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label_categoryAdd.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label_categoryAdd.Visible=false;
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button_approveCategoryiüğ_Click(object sender, EventArgs e)
        {
            _context.Categories.Add(new Category
            {
                Name = textBox_categoryName.Text
            });
            //Open categories list form
        }
    }
}
