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
    public partial class Admin_CategoryBeforeAddingBook : Form
    {
        string Name;
        int Id;
        public Admin_CategoryBeforeAddingBook(string name, int id)
        {
            InitializeComponent();
            Name = name;
            Id = id;
        }

        private void Admin_AddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet8.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.libraryAutomationDataSet8.Categories);

        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void button_approveCategory_Click(object sender, EventArgs e)
        {
            Admin_Add_Book admin_Add_Book = new Admin_Add_Book(Name, Id);
            admin_Add_Book.Show();
            this.Close();
        }

        private void label_goBack_Click(object sender, EventArgs e)
        {
            Admin_MainMenu admin_MainMenu = new Admin_MainMenu(Name, Id);
            admin_MainMenu.Show();
            this.Close();
        }
    }
}
