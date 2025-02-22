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
    public partial class Admin_MainMenu : Form
    {
        string Name;
        User Admin = new User();

        public Admin_MainMenu(string text)
        {
            InitializeComponent();
            label_name.Text = text;
            Name = text;
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Admin_MainMenu_Load(object sender, EventArgs e)
        {
            
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Admin_Book_List _Book_List = new Admin_Book_List(Name);
            _Book_List.Show();
            this.Hide();
        }

        private void toolStripButton_adminUpdate_Click(object sender, EventArgs e)
        {
            Admin_Update_Page admin_Update_ = new Admin_Update_Page(Admin);
            admin_Update_.Show();
            this.Hide();
        }
    }
}
