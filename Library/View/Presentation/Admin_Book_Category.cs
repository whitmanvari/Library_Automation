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
    public partial class Admin_Book_Category : Form
    {
        string Name;
        public Admin_Book_Category(string text)
        {
            InitializeComponent();
            Name = text;
        }

        private void label_gobackAdminMainMenu_Click(object sender, EventArgs e)
        {
            Admin_MainMenu admin_MainMenu = new Admin_MainMenu(Name);
            admin_MainMenu.Show();
            this.Hide();
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
