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

        }
    }
}
