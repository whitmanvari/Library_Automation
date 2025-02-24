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
                int bookId = int.Parse(textBox_bookId.Text);
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
                    Id = bookId,
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
                Admin_Book_List admin_Book_List = new Admin_Book_List(Name, Id);
                admin_Book_List.Show();
                this.Close();
            }
        }
        private bool NullControl()
        {
            if (!int.TryParse(textBox_BookPage.Text, out int value))
            {
                label_BookPageError.Text = "Please enter a valid page number!";
                return false;
            }
            else if (!int.TryParse(textBox_bookId.Text, out int value1))
            {
                label_bookIdError.Text = "Please enter a valid book id!";
                return false;
            }
            else if (!int.TryParse(textBox_BookYear.Text, out int value2))
            {
                label_BookYearError.Text = "Please enter a valid year!";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox_BookAuthor.Text))
            {
                label_BookAuthorError.Text = "Author cannot be empty!";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox_BookGenre.Text))
            {
                label_bookGenreError.Text = "Genre cannot be empty!";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox_BookLanguage.Text))
            {
                label_BookLanguageError.Text = "Language cannot be empty!";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox_BookPublisher.Text))
            {
                label_BookPublisherError.Text = "Publisher cannot be empty!";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(TextBox_Description_book.Text))
            {
                label_BookDescriptionError.Text = "Description cannot be empty!";
                return false;
            }
            else
            {
                return true;
            }
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

