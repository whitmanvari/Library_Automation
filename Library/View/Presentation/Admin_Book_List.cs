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
    public partial class Admin_Book_List : Form
    {
        string Name;
        public Admin_Book_List(string text)
        {
            InitializeComponent();
            Name = text;
        }

        private void Admin_Book_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet7.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryAutomationDataSet7.Books);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Admin_MainMenu mainMenu = new Admin_MainMenu(Name);
            mainMenu.Show();
            this.Hide();
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
