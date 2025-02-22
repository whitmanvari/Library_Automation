using Library.DataContext;
using Library.Model.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.View.Presentation
{
    public partial class Admin_Update_Page : Form
    {
        User Admin;
        LibraryContext context = new LibraryContext();

        public Admin_Update_Page(User admin)
        {
            InitializeComponent();
            Admin = admin;
            textBox_nameAdmin.Text = Admin.Name;
            textbox_adresAdmin.Text = Admin.Address;
            textBox_emailAdmin.Text = Admin.Email;
            textBox_passwordAdmin.Text = Admin.Password;
            textBox_phoneAdmin.Text = Admin.Phone;
            textBox_surnameAdmin.Text = Admin.Surname;
            dateTimePicker_Admin.Value = Admin.BirthDate.Value;
            
        }

        private void label_MemberUpdate_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Admin_Update_Page_Load(object sender, EventArgs e)
        {
           
        }

        private void button_updateAdmin_Click(object sender, EventArgs e)
        {
            var updateAdmin = context.Users.FirstOrDefault(u => u.Id == Admin.Id);

            if (updateAdmin != null)  // Whether there is an admin record or not control!
            {
                updateAdmin.Name = textBox_nameAdmin.Text;
                updateAdmin.Address = textbox_adresAdmin.Text;
                updateAdmin.BirthDate = dateTimePicker_Admin.Value;
                updateAdmin.Email = textBox_emailAdmin.Text;
                updateAdmin.Phone = textBox_phoneAdmin.Text;
                updateAdmin.Password = textBox_passwordAdmin.Text;
                updateAdmin.Surname = textBox_surnameAdmin.Text;
                context.SaveChanges();
                MessageBox.Show("Update is succesfull!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //go to main menu again
                Admin_MainMenu admin_Main = new Admin_MainMenu(Admin.Name);
                admin_Main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("There are no records, if you are not signed up please go to the register page!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
