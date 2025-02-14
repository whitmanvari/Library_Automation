﻿using Library.DataContext;
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

            if (StringControl(EmailControl) || StringControl(PasswordControl))
            {
                MessageBox.Show("Error, incorrect informations. If you do not have an account, please sign up!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var adminUser = context.Users.FirstOrDefault(u => u.Email == txt_AdminEmail_Login.Text && u.Password == txt_AdminPassword_Login.Text);
            //User cannot be null.

            if (adminUser == null)
            {
                MessageBox.Show("The user could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Admin_MainMenu admin_MainMenu = new Admin_MainMenu();
            admin_MainMenu.Show();
            this.Hide();
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
            string emailControl = textBox_MemberEmail_Phone_UserNameControl_LoginPage.Text.Trim();
            string phoneControl = textBox_MemberEmail_Phone_UserNameControl_LoginPage.Text.Trim();
            string userNameControl = textBox_MemberEmail_Phone_UserNameControl_LoginPage.Text.Trim();
            string passwordControl = textBox_MemberPasswordControl_LoginPage.Text.Trim();

            if (StringControl(emailControl) || StringControl(phoneControl) || StringControl(userNameControl))
            {
                MessageBox.Show("Error, incorrect informations. If you do not have an account please sign up!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var memberUser = context.Users.FirstOrDefault(u => u.Email == textBox_MemberEmail_Phone_UserNameControl_LoginPage.Text
            || u.Phone == textBox_MemberEmail_Phone_UserNameControl_LoginPage.Text 
            || u.Name == textBox_MemberEmail_Phone_UserNameControl_LoginPage.Text 
            && u.Password == textBox_MemberPasswordControl_LoginPage.Text);


        }
    }
}
