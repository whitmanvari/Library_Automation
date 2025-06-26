using Library.DataContext; //ef contex bağlantısı buradan çekiliyor
using Library.Model.Concrete; //model classları buradan çekiliyor
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library.View.Presentation //uı katmanı, kullanıcı kayıt sorgusu
{
    public partial class Login : Form
    {
        private Random random = new Random();
        private int moveDistance = 30; //30 pixel hareket mesafesi
        private int safetyMargin = 20; //20 pixel kenar boşluğu, butonun form kenarına çok yaklaşmasını engellemek için
        string Email;
        string Password;
        string Name;
        int Id;
        LibraryContext context = new LibraryContext();
        public Login()
        {
            InitializeComponent();
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


        private void button_Enter_LoginPage_Click(object sender, EventArgs e) //admnin entrance button
        {
            if(StringControl(txt_AdminEmail_Login.Text, label_errorEmail)) { return; }
            if (StringControl(txt_AdminPassword_Login.Text, label_errorPassword)) { return; }
            List<User> users = new List<User>();
            users = context.Users.Where(u => u.Email == txt_AdminEmail_Login.Text).ToList();
            

            foreach (var admin in users)
            {
                Email = admin.Email.ToString();
                Password = admin.Password.ToString();
                Name = admin.Name.ToString();
                Id = admin.Id;
            }
            if(Email == txt_AdminEmail_Login.Text)
            {
                if (Password == txt_AdminPassword_Login.Text)
                {
                    MessageBox.Show("Welcome!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin_MainMenu adminMainMenu = new Admin_MainMenu(Name, Id);
                    adminMainMenu.Show();
                    this.Hide();
                }
                else
                {
                   MessageBox.Show("The password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The user could not be found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btn_Enter_MemberLoginPage_Click_1(object sender, EventArgs e) //member entrance button
        {
            if(StringControl(txt_emailMember.Text, lbl_error_email_member)) { return; }
            if (StringControl(txt_passwordmember.Text, lbl_error_password_member)) { return; }
            List<User> users = new List<User>();
            users = context.Users.Where(u => u.Email == txt_emailMember.Text).ToList();
            foreach (var members in users)
            {
                Email = members.Email.ToString();
                Password = members.Password.ToString();
                Name = members.Name.ToString();
                Id = members.Id;
            }
            if(Email == txt_emailMember.Text)
            {
                if(Password == txt_passwordmember.Text)
                {
                    MessageBox.Show("Welcome!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Member_MainMenu member_Main = new Member_MainMenu(Name, Id);
                    member_Main.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("There is no record like this, please sign up if you do not have an account!");
                }
            }
            else
            {
                MessageBox.Show("There is no record like this, please sign up if you do not have an account!");
            }


            if (users == null)
            {
                MessageBox.Show("The user could not be found, if you are not a member first sign up!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           


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
            lbl_error_email_member.Text = "";
        }

        private void textBox_MemberPasswordControl_LoginPage_TextChanged(object sender, EventArgs e)
        {
            label_ErrorMessage_LoginPage_AdminPassword.Text = "";
        }


        private void btn_ExitLoginPage_MouseMove(object sender, MouseEventArgs e)
        { 
            Button btn = (Button)sender;

            //Angle will be random
            int angle = random.Next(0, 360);
            double radians = angle * Math.PI / 180;
            //New coordinates:
            int newX = btn.Left + (int)(moveDistance*Math.Cos(radians));
            int newY = btn.Top + (int)(moveDistance* Math.Sin(radians));

            //Control form borders:
            newX = Math.Max(safetyMargin, Math.Min( newX, this.ClientSize.Width - btn.Width - safetyMargin));
            newY = Math.Max(safetyMargin, Math.Min(newY, this.ClientSize.Height - btn.Height - safetyMargin));

            btn.Location = new Point(newX, newY); //update position
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
