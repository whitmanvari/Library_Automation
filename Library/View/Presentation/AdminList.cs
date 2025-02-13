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
    public partial class AdminList : Form
    {
        public AdminList()
        {
            InitializeComponent();
        }

        private void AdminList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet5.Admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.libraryAutomationDataSet5.Admins);

        }
    }
}
