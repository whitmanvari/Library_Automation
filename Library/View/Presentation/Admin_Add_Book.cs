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
        int SelectedCategoryId;

        public Admin_Add_Book(string name, int id, int categoryId)
        {
            InitializeComponent();
            Name = name;
            Id = id;
            SelectedCategoryId = categoryId;
        }


        private void button_addBook_Click(object sender, EventArgs e)
        {

            if (NullControl())
            {
                string bookName = textBox_bookName.Text;
                string bookAuthor = textBox_BookAuthor.Text;
                string bookPublisher = textBox_BookPublisher.Text;
                int bookPage = int.Parse(textBox_BookPage.Text);
                string bookGenre = textBox_BookGenre.Text;
                string bookLanguage = textBox_BookLanguage.Text;
                int bookYear = int.Parse(textBox_BookYear.Text);
                string bookDescription = TextBox_Description_book.Text;
                bool isBookActive = checkBox_isactive.Checked;

                var book = new Book
                {
                    BookName = bookName,
                    BookAuthor = bookAuthor,
                    BookPublisher = bookPublisher,
                    BookPage = bookPage,
                    BookLanguage = bookLanguage,
                    BookDescription = bookDescription,
                    BookGenre = bookGenre,
                    IsActive = isBookActive,
                    BookYear = bookYear,
                    CreatedDate = DateTime.Now,
                    CategoryId = SelectedCategoryId
                };

                context.Books.Add(book);
                context.SaveChanges();
                MessageBox.Show("Book added successfully!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Admin_Book_List admin_Book_List = new Admin_Book_List(Name, Id, SelectedCategoryId);
                admin_Book_List.Show();
                this.Close();
            }
        }
        private bool NullControl()
        {
            bool hasError = true;
            if (string.IsNullOrWhiteSpace(textBox_bookName.Text))
            {
                label_bookNameError.Text = "Book name cannot be empty!";
                hasError = false;
            }
            if (!int.TryParse(textBox_BookPage.Text, out int value))
            {
                label_BookPageError.Text = "Please enter a valid page number!";
                hasError = false;
            }
            if (!int.TryParse(textBox_BookYear.Text, out int value2))
            {
                label_BookYearError.Text = "Please enter a valid year!";
                hasError = false;
            }
            if (string.IsNullOrWhiteSpace(textBox_BookAuthor.Text))
            {
                label_BookAuthorError.Text = "Author cannot be empty!";
                hasError = false;
            }
            if (string.IsNullOrWhiteSpace(textBox_BookGenre.Text))
            {
                label_bookGenreError.Text = "Genre cannot be empty!";
                hasError = false;
            }
            if (string.IsNullOrWhiteSpace(textBox_BookLanguage.Text))
            {
                label_BookLanguageError.Text = "Language cannot be empty!";
                hasError = false;
            }
            if (string.IsNullOrWhiteSpace(textBox_BookPublisher.Text))
            {
                label_BookPublisherError.Text = "Publisher cannot be empty!";
                hasError = false;
            }
            if (string.IsNullOrWhiteSpace(TextBox_Description_book.Text))
            {
                label_BookDescriptionError.Text = "Description cannot be empty!";
                hasError = false;
            }
                return hasError;
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

        private void textBox_bookName_TextChanged(object sender, EventArgs e)
        {
            label_bookNameError.Text = "";
        }

        private void textBox_BookAuthor_TextChanged(object sender, EventArgs e)
        {
            label_BookAuthorError.Text = "";
        }

        private void textBox_BookGenre_TextChanged(object sender, EventArgs e)
        {
            label_bookGenreError.Text = "";
        }

        private void textBox_BookPage_TextChanged(object sender, EventArgs e)
        {
            label_BookPageError.Text = "";
        }

        private void textBox_BookYear_TextChanged(object sender, EventArgs e)
        {
            label_BookYearError.Text = "";
        }

        private void textBox_BookLanguage_TextChanged(object sender, EventArgs e)
        {
            label_BookLanguageError.Text = "";
        }

        private void textBox_BookPublisher_TextChanged(object sender, EventArgs e)
        {
            label_BookPublisherError.Text = "";
        }

        private void TextBox_Description_book_TextChanged(object sender, EventArgs e)
        {
            label_BookDescriptionError.Text = "";
        }

        private void Admin_Add_Book_Load(object sender, EventArgs e)
        {

        }
    }
}

