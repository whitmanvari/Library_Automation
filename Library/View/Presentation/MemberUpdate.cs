using Library.DataContext;
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
    public partial class MemberUpdate : Form
    {
        private User Member;
        LibraryContext Context = new LibraryContext();
        public MemberUpdate(User member)
        {
            InitializeComponent();
            textBox_namemember.Text = member.Name;
            textBox_emailmember.Text = member.Email;
            textbox_adresmember.Text = member.Address;
            textBox_surnamemember.Text = member.Surname;
            dateTimePicker_member.Value = member.BirthDate.Value;
            textBox_passwordmember.Text = member.Password;
            textBox_phonemember.Text = member.Phone;
            Member = member;
            

        }

        private void label_MemberUpdate_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void MemberUpdate_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var existingMember = Context.Users.FirstOrDefault(u => u.Id == Member.Id);

            if (existingMember != null)  // Eğer kullanıcı varsa
            {
                existingMember.Name = textBox_namemember.Text;
                existingMember.Address = textbox_adresmember.Text;
                existingMember.BirthDate = dateTimePicker_member.Value;
                existingMember.Email = textBox_emailmember.Text;
                existingMember.Phone = textBox_phonemember.Text;
                existingMember.Password = textBox_passwordmember.Text;
                existingMember.Surname = textBox_surnamemember.Text;
                Context.SaveChanges();
                MessageBox.Show("Update is succesfull!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //go to main menu again
                Member_MainMenu menu = new Member_MainMenu(existingMember.Name);
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("There are no records, if you are not signed up please go to the register page!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Member_MainMenu member_MainMenu = new Member_MainMenu(Member.Name);
            member_MainMenu.Show();
            this.Close();
        }
    }
}
