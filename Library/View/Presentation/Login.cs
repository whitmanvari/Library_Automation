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

        private void Button_Enter_LoginPage_Click(object sender, EventArgs e)
        {

        }

        private void btn_Enter_MemberLoginPage_Click(object sender, EventArgs e)
        {
           
        }

        private void button_Enter_LoginPage_Click(object sender, EventArgs e)
        {
            string EmailControl = txt_AdminEmail_Login.Text?.Trim();
            string PasswordControl = txt_AdminPassword_Login.Text?.Trim();
            string RoleControl = comboBox_LoginRole.SelectedItem.ToString().Trim();
            if(StringControl(EmailControl) || StringControl(PasswordControl) || StringControl(RoleControl))
            {
                MessageBox.Show("Error!");
            }

            bool isEmailValid = StringControl(txt_AdminEmail_Login.Text);
            bool isPasswordValid = StringControl(txt_AdminPassword_Login.Text);
            bool isRoleValid = StringControl(comboBox_LoginRole.Text);
            //var adminUser = context.admin.FirstOrDefault(a => a.Email == txt_AdminEmail_Login.Text && a.Password == txt_AdminPassword_Login.Text && a.Role == comboBox_LoginRole.SelectedItem.ToString());

            // User cannot be null.
            //if (adminUser == null)
            //{
            //    MessageBox.Show("The user could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //If one of the validations are false stop the function!
            if (isEmailValid || isPasswordValid || isRoleValid)
            {
                Admin_MainMenu admin_MainMenu = new Admin_MainMenu();
                admin_MainMenu.Show();
                this.Hide();
            }
            




        }

        public bool StringControl(string text)
        {
            if (string.IsNullOrEmpty(text) && string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            return true;
        }
    }
}
