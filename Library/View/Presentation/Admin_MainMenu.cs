using Library.DataContext;
using Library.Model.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.View.Presentation
{
    public partial class Admin_MainMenu : Form
    {

        string Name;
        int Id;
        LibraryContext LibraryContext = new LibraryContext();
        

        public Admin_MainMenu(string text, int id)
        {
            InitializeComponent();
            label_name.Text = text;
            Name = label_name.Text;
            Id = id;
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

       
        private void toolStripButton_adminUpdate_Click(object sender, EventArgs e)
        {
            var admin = LibraryContext.Users.FirstOrDefault(u => u.Id == Id);
            //Null Control
            if(admin == null)
            {
                MessageBox.Show("There are no records like this!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Admin_Update_Page admin_Update_ = new Admin_Update_Page(admin);
            admin_Update_.Show();
            this.Hide();
        }

        private void toolStripButton_adminUpdate_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_adminUpdate.Visible = true;
        }

        private void toolStripButton_adminUpdate_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_adminUpdate.Visible = false;
        }

        private void toolStripButton2_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_bookCategory_Admin.Visible = true;
        }

        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_bookCategory_Admin.Visible= false;
        }

        private void toolStripButton_bookCategory_Click(object sender, EventArgs e)
        {
            Admin_Book_Category admin_Book_Category = new Admin_Book_Category(Name, Id);
            admin_Book_Category.Show();
            this.Hide();
        }

        private void toolStripButton1_MouseHover_1(object sender, EventArgs e)
        {
            toolStripLabel_addBook.Visible = true;
        }

        private void toolStripButton1_MouseLeave_1(object sender, EventArgs e)
        {
            toolStripLabel_addBook.Visible = false;
        }

        private void toolStripButton2_MouseHover_1(object sender, EventArgs e)
        {
            toolStripLabel_AddCategory.Visible = true;
        }

        private void toolStripButton2_MouseLeave_1(object sender, EventArgs e)
        {
            toolStripLabel_AddCategory.Visible= false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Admin_CategoryBeforeAddingBook admin_CategoryBeforeAddingBook = new Admin_CategoryBeforeAddingBook(Name, Id);
            admin_CategoryBeforeAddingBook.Show();
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory(Name, Id);
            addCategory.Show();
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            lbl_selectOperation.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lbl_selectOperation.Visible= false;
        }

        private void lbl_selectOperation_Click(object sender, EventArgs e)
        {

        }
    }
}
