using Library.DataContext;
using System;
using System.Windows.Forms;

namespace Library.View.Presentation
{
    public partial class Login : Form
    {
        LibraryContext context = new LibraryContext();
        public Login()
        {
            InitializeComponent();
        }

        private void txt_AdminRole_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet3.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.libraryAutomationDataSet3.Admins);

        }

        private void toolTip__Popup(object sender, PopupEventArgs e)
        {

        }

        private void label_LoginPage_Signin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void linkLabel_AdminLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void linkLabel_MemberLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void btn_Enter_MemberLoginPage_Click(object sender, EventArgs e)
        {

        }
    }
}
