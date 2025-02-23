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
    }
}
