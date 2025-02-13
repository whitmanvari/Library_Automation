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
    public partial class MemberList : Form
    {
        public MemberList()
        {
            InitializeComponent();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryAutomationDataSet4.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.libraryAutomationDataSet4.Members);

        }
    }
}
