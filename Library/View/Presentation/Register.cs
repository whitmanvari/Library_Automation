﻿using Library.DataContext;
using Library.Model.Concrete;
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
            libraryContext.Roles.Add(new Role { Name = "Admin" });
            libraryContext.Roles.Add(new Role { Name = "Member" });
            

            string adminName = textBox_AdminName_Register.Text;
            string adminSurname = textBox_AdminSurname_Register.Text;
            string adminEmail = textBox_AdminEmail_Register.Text;
            string adminPhone = textBox_AdminPhone_Register.Text;
            string adminPassword = textBox_AdminPassword_Register.Text;
            DateTime adminBirthDate = dateTimePicker_birthdate.Value;
            string adminAddress = textBox_AdminAdress_Register.Text;

            bool isNameInValid = IsStringValid(adminName, "Admin name cannot be empty!", label_AdminNameError_Register);
            bool isSurnameInValid = IsStringValid(adminSurname, "Admin surname cannot be empty!", lbl_errorAdminSurname_Register);
            bool isEmailInValid = IsStringValid(adminEmail, "Admin email cannot be empty!", lbl_AdminEmailError_Register);
            bool isPhoneInValid = IsStringValid(adminPhone, "Admin phone cannot be empty!", label_AdminPhoneError_Register);
            bool isAddressInValid = IsStringValid(adminAddress, "Admin address cannot be empty!", label_AdminAdressError_Register);
            bool isPasswordInValid = IsStringValid(adminPassword, "Admin password cannot be empty!", label_AdminPasswordError_Register);
           

            if (!isAddressInValid && !isEmailInValid && !isNameInValid && !isPasswordInValid && !isPhoneInValid && !isSurnameInValid) 
            {
                var adminUserMailCheck = libraryContext.Users.FirstOrDefault(u => u.Email == adminEmail);
                if (adminUserMailCheck != null)
                {
                    lbl_AdminEmailError_Register.Text = "This email is already in use!";
                    return;
                }
                var adminUserPhoneCheck = libraryContext.Users.FirstOrDefault(u => u.Phone == adminPhone);
                if (adminUserPhoneCheck != null)
                {
                    label_AdminPhoneError_Register.Text = "This phone is already in use!";
                    return;
                }
                return;
            }

            var adminUser = new User
            {
                Name = adminName,
                Surname = adminSurname,
                Email = adminEmail,
                Phone = adminPhone,
                Password = adminPassword,
                BirthDate = adminBirthDate, // Ensure this is within the valid range
                Address = adminAddress,
                RoleId = 1
            };

            libraryContext.Users.Add(adminUser);
            libraryContext.SaveChanges();
                MessageBox.Show("Admin registration is successful!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login login = new Login();
                login.Show();
                this.Hide();
        }
        public bool IsStringValid(string text, string errorMessage, Label label)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                label.Text = errorMessage;
                return false; // Boşsa false döndür
            }
            label.Text = "";
            return true; // Doluysa true döndür
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

