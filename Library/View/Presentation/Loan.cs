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
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void label_Loan_signinPage_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Loan_Load(object sender, EventArgs e)
        {

        }
    }
}
