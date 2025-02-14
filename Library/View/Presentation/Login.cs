using Library.DataContext;
using System;
using System.Linq;
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


        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet3.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.libraryAutomationDataSet3.Admins);

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


        private void button_Enter_LoginPage_Click(object sender, EventArgs e)
        {
            string EmailControl = txt_AdminEmail_Login.Text?.Trim();
            string PasswordControl = txt_AdminPassword_Login.Text?.Trim();
           
            if (StringControl(EmailControl) || StringControl(PasswordControl) )
            {
                MessageBox.Show("Error!");
            }

            bool isEmailInValid = StringControl(txt_AdminEmail_Login.Text);
            bool isPasswordInValid = StringControl(txt_AdminPassword_Login.Text);
           

            //If one of the validations are false stop the function!
            if (!isEmailInValid || !isPasswordInValid)
            {
                Admin_MainMenu admin_MainMenu = new Admin_MainMenu();
                admin_MainMenu.Show();
                this.Hide();
            }
            var adminUser = context.Users.FirstOrDefault(a => a.Email == txt_AdminEmail_Login.Text && a.Password == txt_AdminPassword_Login.Text);
            //User cannot be null.
            if (adminUser == null)
            {
                MessageBox.Show("The user could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool StringControl(string text)
        {
            if (string.IsNullOrEmpty(text) && string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }

        private void btn_Enter_MemberLoginPage_Click_1(object sender, EventArgs e)
        {

        }
    }
}
