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
    public partial class Admin_Update_Page : Form
    {
        User Admin;

        public Admin_Update_Page(User admin)
        {
            InitializeComponent();
            Admin = admin;
            
        }

        private void label_MemberUpdate_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Admin_Update_Page_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_MainMenu mainMenu = new Admin_MainMenu(Admin.Name);
            mainMenu.Show();
            this.Hide();
        }
    }
}
