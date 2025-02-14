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
    public partial class Register : Form
    {
        LibraryContext libraryContext = new LibraryContext();
        public Register()
        {
            InitializeComponent();
        }


        private void label_Register_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button_Enter_LoginPage_Click(object sender, EventArgs e)
        {
            string adminName = textBox_AdminName_Register.Text;
            string adminSurname = textBox_AdminSurname_Register.Text;
            string adminEmail = textBox_AdminEmail_Register.Text;
            string adminPhone = textBox_AdminPhone_Register.Text;
            string adminPassword = textBox_AdminPassword_Register.Text;
            string adminBirthDate = textBox_AdminBirthDate_Register.Text;
            string adminAddress = textBox_AdminAdress_Register.Text;

            bool isNameValid = StringControl(adminName, "Admin name cannot be empty!", label_AdminNameError_Register, label_AdminName);
            bool isSurnameValid = StringControl(adminSurname, "Admin Surname cannot be empty!", lbl_errorAdminSurname_Register, label_AdminSurname);
            bool isEmailValid = StringControl(adminEmail, "Admin ")


        }
        public bool StringControl(string text, string errorMessage, Label label, Label NameStar)
        {
            if (!string.IsNullOrEmpty(text))
            {
                return true;
            }
            label.Text = errorMessage;
            if (!NameStar.Text.Contains("*"))
            {
                NameStar.Text = "*";
            }
            return false;
        }
    }
}
}
