using Library.DataContext;
using Library.Model.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.View.Presentation
{
    public partial class MemberLoan : Form
    {
        LibraryContext context = new LibraryContext();
        List<Book> BookListShow;
        int id;
        public MemberLoan(int userId)
        {
            InitializeComponent();
            id = userId;
        }

        private void label_Loan_signinPage_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Loan_Load(object sender, EventArgs e)
        {
            var bookListShow = context.Books.ToList();
            BookListShow = bookListShow;

            // TODO: This line of code loads data into the 'libraryAutomationDataSet10.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryAutomationDataSet10.Books);

        }

        private void checkInDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                Book selectedBook = context.Books.FirstOrDefault(b => b.Id == bookId);
                if (selectedBook != null)
                {
                    CheckInDetail checkInDetail = new CheckInDetail(selectedBook);
                    checkInDetail.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("We could not found the correct book!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                int bookId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value); //id al
                //userıd çek
                Loan newLoan = new Loan
                {
                    BookId= bookId,
                    UserId= id,
                    LoanDate=DateTime.Now,
                    CreatedDate=DateTime.Now,
                    //ReturnDate

                };
            }
        }
    }
}
