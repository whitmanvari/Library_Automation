using Library.DataContext;
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
        LibraryContext context = new LibraryContext();
        public Member_MainMenu(string text)
        {
            InitializeComponent();
            label_memberName.Text = text;

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
            BookList bookList = new BookList();
            bookList.Show();
            this.Close();
        }

        private void Member_MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_myProfile.Visible = true;
        }

        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_myProfile.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var member = context.Users.FirstOrDefault(u => u.Name == label_memberName.Text);

            MemberUpdate memberUpdate = new MemberUpdate(member);
            memberUpdate.Show();
            this.Hide();
        }
    }
}
