using Library.DataContext;
using System;
using System.Data;
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
            string emailControl = txt_AdminEmail_Login.Text?.Trim();
            string passwordControl = txt_AdminPassword_Login.Text?.Trim();

            if (StringControl(emailControl, label_errorEmail)) { return; }
            if (StringControl(passwordControl, label_errorPassword)) { return; }
            var adminUserMailCheck = context.Users.FirstOrDefault(u => u.Email == txt_AdminEmail_Login.Text);
            var adminUserPasswordCheck = context.Users.FirstOrDefault(u => u.Password == txt_AdminPassword_Login.Text);
           
            //User checks cannot be null!

            if (adminUserMailCheck == null)
            {
                MessageBox.Show("The user mail could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(adminUserPasswordCheck == null)
            {
                MessageBox.Show("The user password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Admin_MainMenu admin_MainMenu = new Admin_MainMenu();
            admin_MainMenu.Show();
            this.Hide();
        }

        //String Text Control
        public bool StringControl(string text, Label label)
        {
            bool control = false;
            if (string.IsNullOrWhiteSpace(text))
            {
                label.Text = "This area is mandatory!";
                control = true;
                return control;
            }
            return control;
        }

        private void btn_Enter_MemberLoginPage_Click_1(object sender, EventArgs e)
        {
            string inputControl = textBox_MemberEmail_Phone_UserNameControl_LoginPage.Text.Trim();
            string passwordControl = textBox_MemberPasswordControl_LoginPage.Text.Trim();

            if (StringControl(inputControl, label_ErrorMessage_LoginPage_AdminEmail)) { return; }
            if (StringControl(passwordControl, label_ErrorMessage_LoginPage_AdminPassword)) { return; }

            var memberUser = context.Users.FirstOrDefault(u =>
           (IsValidEmail(inputControl) && u.Email == inputControl) ||
           (IsValidPhone(inputControl) && u.Phone == inputControl) ||
           (IsValidUserName(inputControl) && u.Name == inputControl)
              && u.Password == passwordControl
             );

            if (memberUser == null)
            {
                MessageBox.Show("The user could not be found, if you are not a member first sign up!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Member_MainMenu member_MainMenu = new Member_MainMenu();
            member_MainMenu.Show();
            this.Hide();


        }
        //Email Control
        public bool IsValidEmail(string text)
        {
            return text.Contains("@") && text.Contains(".") && text.Contains("com");
        }
        //Phone Control
        public bool IsValidPhone(string text)
        {
            return text.All(char.IsDigit);
        }
        //User Name Control
        public bool IsValidUserName(string text)
        {
            return text.All(char.IsLetterOrDigit);
        }

        private void txt_AdminEmail_Login_TextChanged(object sender, EventArgs e)
        {
            label_errorEmail.Text = "";
        }

        private void txt_AdminPassword_Login_TextChanged(object sender, EventArgs e)
        {
            label_errorPassword.Text = "";
        }

        private void textBox_MemberEmail_Phone_UserNameControl_LoginPage_TextChanged(object sender, EventArgs e)
        {
            label_errorMessage_Loginpage_MemberEmail.Text = "";
        }

        private void textBox_MemberPasswordControl_LoginPage_TextChanged(object sender, EventArgs e)
        {
            label_ErrorMessage_LoginPage_AdminPassword.Text = "";
        }
    }
}
