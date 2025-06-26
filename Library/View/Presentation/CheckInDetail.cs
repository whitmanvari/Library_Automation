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
    public partial class CheckInDetail : Form
    {
        Book SelectedBook;
        Category BookCategory;
        string MemberName;
        int MemberId;
        public CheckInDetail(Book selectedBook, string memberName, int memberId, Category category)
        {
            InitializeComponent();
            SelectedBook = selectedBook;
            BookCategory = category;
            MemberName = memberName;
            MemberId = memberId;

            
        }

        private void CheckInDetail_Load(object sender, EventArgs e)
        {
            textBox_BookAuthor.Text = SelectedBook.BookAuthor;
            textBox_BookGenre.Text = SelectedBook.BookGenre;
            textBox_BookLanguage.Text = SelectedBook.BookLanguage;
            textBox_bookName.Text = SelectedBook.BookName;
            textBox_BookPage.Text = SelectedBook.BookPage.ToString();
            textBox_BookPublisher.Text = SelectedBook.BookPublisher;
            textBox_BookYear.Text = SelectedBook.BookYear.ToString();
            TextBox_Description_book.Text = SelectedBook.BookDescription;
        }

        private void linkLabel_goBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BookList bookList = new BookList(MemberName, BookCategory, MemberId);
            bookList.Show();
            this.Close();
        }
    }
}
