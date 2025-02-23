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
    public partial class Admin_Add_Book : Form
    {
        LibraryContext context = new LibraryContext();
        string Name;
        int Id;

        public Admin_Add_Book(string name, int id)
        {
            InitializeComponent();
            Name = name;
            Id = id;
        }
        private void LoadCategories()
        {
            try
            {
                combobox_
            }
            catch(Exception ex) 
            {
                MessageBox.Show("There must be something wrong while categoies uploading!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Admin_Add_Book_Load(object sender, EventArgs e)
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
        }

        private void button_addBook_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBox_bookId.Text);
            string bookName = textBox_bookName.Text;
            string bookAuthor = textBox_BookAuthor.Text;
            int bookCategoryId = int.Parse(textBox_CategoryId.Text);
            string bookPublisher = textBox_BookPublisher.Text;
            int bookPage = int.Parse(textBox_BookPage.Text);
            string bookGenre = textBox_BookGenre.Text;
            string bookLanguage = textBox_BookLanguage.Text;
            int bookYear = int.Parse(textBox_BookYear.Text);
            string bookDescription = TextBox_Description_book.Text;
            bool isBookActive = checkBox_isactive.Checked;

            if (IsNullControl(textBox_bookId.Text, label_bookIdError.Text)
                || IsNullControl(textBox_BookAuthor.Text, label_BookAuthorError.Text)
                || IsNullControl(textBox_CategoryId.Text, label_CategoryIdError.Text)
                || IsNullControl(textBox_BookGenre.Text, label_bookGenreError.Text)
                || IsNullControl(textBox_BookLanguage.Text, label_BookLanguageError.Text)
                || IsNullControl(textBox_bookName.Text, label_bookNameError.Text)
                || IsNullControl(textBox_BookPage.Text, label_BookPageError.Text)
                || IsNullControl(textBox_BookPublisher.Text, label_BookPublisherError.Text)
                || IsNullControl(textBox_BookYear.Text, label_BookYearError.Text)
                || IsNullControl(TextBox_Description_book.Text, label_BookDescriptionError.Text)
                || IsNullControl(textBox_CreatedDate.Text, label_CreatedDateError.Text)
                || IsNullControl(checkBox_isactive.Text, label_isActiveError.Text)) { return; }
            {

                var book = new Book
                {
                    Id = bookId,
                    BookName = bookName,
                    BookAuthor = bookAuthor,
                    CategoryId = bookCategoryId,
                    BookPublisher = bookPublisher,
                    BookPage = bookPage,
                    BookLanguage = bookLanguage,
                    BookDescription = bookDescription,
                    BookGenre = bookGenre,
                    IsActive = isBookActive,
                    BookYear = bookYear,
                    CreatedDate = DateTime.Now,
                };
                context.Books.Add(book);
                context.SaveChanges();
                MessageBox.Show("Book added successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool IsNullControl(string text, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                errorMessage = "This area cannot be left empty!";
                return true;
            }
            return false;
        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void linkLabel_goBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_MainMenu admin_MainMenu = new Admin_MainMenu(Name, Id);
            admin_MainMenu.Show();
            this.Close();
        }
    }
}

