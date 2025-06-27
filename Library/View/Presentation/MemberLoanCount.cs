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
    public partial class MemberLoanCount : Form
    {
        public MemberLoanCount()
        {
            InitializeComponent();
        }

        private void MemberLoanCount_Load(object sender, EventArgs e)
        {
            nud_ReturnDate.Minimum = 1;
            nud_ReturnDate.Maximum = 14; //maksimum 14 gün sonra iade edebilir.
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            DateTime checkoutDate = dtp_checkoutDate.Value; //Hangi tarihte kiralamaya başlayacağını aldık kitabı.
            int loanDays = (int)nud_ReturnDate.Value; //Kaç gün kiralayacağını aldık.

            DateTime expectedReturnDate = checkoutDate.AddDays(loanDays); //Beklenen iade tarihini hesapladık.
            lbl_expectedReturnDate.Text = "Return By: " + expectedReturnDate.ToShortDateString(); //Beklenen iade tarihini gösterdik, sadece gün ay ve yıl şeklinde.
            //şimdi kontroller
            if (checkoutDate > DateTime.Now)
            {
                MessageBox.Show("Loan hasn't started yet!", "İnfo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DateTime.Now > expectedReturnDate)
            {
                MessageBox.Show("Late, book must have been returned before that date!", "İnfo!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TimeSpan remains = expectedReturnDate - DateTime.Now; //Kalan süreyi hesapladık.
                lbl_expectedReturnDate.Text = $"Loan Date: {checkoutDate:dd/MM/yyyy}\n" +
                $"Loan Duration: {loanDays} days\n" +
                $"Expected Return: {expectedReturnDate:dd/MM/yyyy}";
            }
        }
    }
}
