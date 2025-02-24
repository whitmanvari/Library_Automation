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
    public partial class Admin_CategoryBeforeAddingBook : Form
    {
        LibraryContext context = new LibraryContext();
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
            CreateCategory();
            // TODO: This line of code loads data into the 'libraryAutomationDataSet8.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.libraryAutomationDataSet8.Categories);

        }
        private void CreateCategory()
        {
            Category scienceFiction = new Category
            {
                Id = 1,
                Name = "Science Fiction",
                CreatedDate = DateTime.Now
            };
            Category romance = new Category
            {
                Id = 2,
                Name = "Romance",
                CreatedDate = DateTime.Now
            };
            Category literaryFiction = new Category
            {
                Id = 3,
                Name = "Literary Fiction",
                CreatedDate = DateTime.Now
            };
            Category horror = new Category
            {
                Id = 4,
                Name = "Horror",
                CreatedDate = DateTime.Now
            };
            Category fantasy = new Category
            {
                Id = 5,
                Name = "Fantasy",
                CreatedDate = DateTime.Now
            };
            Category historicalFiction = new Category
            {
                Id = 6,
                Name = "Historical Fiction",
                CreatedDate = DateTime.Now
            };
            Category poetry = new Category
            {
                Id = 7,
                Name = "Poetry",
                CreatedDate = DateTime.Now
            };
            Category adventure = new Category
            {
                Id = 8,
                Name = "Adventure",
                CreatedDate = DateTime.Now
            };
            Category philosophy = new Category
            {
                Id = 9,
                Name = "Philosophy",
                CreatedDate = DateTime.Now
            };
            Category fairyTale = new Category
            {
                Id = 10,
                Name = "Fairy Tale",
                CreatedDate = DateTime.Now
            };
            Category dystopian = new Category
            {
                Id = 11,
                Name = "Dystopian",
                CreatedDate = DateTime.Now
            };
            Category biography = new Category
            {
                Id = 12,
                Name = "Biography",
                CreatedDate = DateTime.Now
            };
            context.Categories.Add(scienceFiction);
            context.Categories.Add(romance);
            context.Categories.Add(literaryFiction);
            context.Categories.Add(horror);
            context.Categories.Add(fantasy);
            context.Categories.Add(historicalFiction);
            context.Categories.Add(poetry);
            context.Categories.Add(adventure);
            context.Categories.Add(philosophy);
            context.Categories.Add(fairyTale);
            context.Categories.Add(dystopian);
            context.Categories.Add(biography);
            context.SaveChanges();

            
            
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void button_approveCategory_Click(object sender, EventArgs e)
        {
            comboBox_chooseCategory.SelectedValue.ToString();
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
