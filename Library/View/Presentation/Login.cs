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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txt_AdminRole_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet3.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.libraryAutomationDataSet3.Admins);

        }

        private void toolTip__Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
