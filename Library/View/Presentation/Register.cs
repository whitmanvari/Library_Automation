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
            string adminAddress = fgh.Text;

            bool isNameValid = StringControl(adminName, "Admin name cannot be empty!", label_AdminNameError_Register, label_AdminName);
            bool isSurnameValid = StringControl(adminSurname, "Admin surname cannot be empty!", lbl_errorAdminSurname_Register, label_AdminSurname);
            bool isEmailValid = StringControl(adminEmail, "Admin email cannot be empty!", lbl_AdminEmailError_Register, label_AdminEmail);
            bool isPhoneValid = StringControl(adminPhone, "Admin phone cannot be empty!", label_AdminPhoneError_Register, label_AdminPhone);
            bool isAddressValid = StringControl(adminAddress, "Admin address cannot be empty!", label_AdminAdressError_Register, label_AdminAdress);
            bool isPasswordValid = StringControl(adminPassword, "Admin password cannot be empty!", label_AdminPasswordError_Register, label_AdminPassword);
            bool 


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

