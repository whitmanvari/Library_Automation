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
    public partial class Member_MainMenu : Form
    {
        public Member_MainMenu()
        {
            InitializeComponent();
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void toolStripButton_booklist_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_booklist.Visible = true;
        }

        private void toolStripButton_booklist_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_booklist.Visible = false;
        }

        private void toolStripButton_loanpage_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_bookloan.Visible = true;
        }

        private void toolStripButton_loanpage_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_bookloan.Visible = false;
        }

        private void toolStripButton_booklist_Click(object sender, EventArgs e)
        {

        }
    }
}
