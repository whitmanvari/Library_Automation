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
    public partial class Category_List_Member : Form
    {
        string Name;
        public Category_List_Member(string text)
        {
            InitializeComponent();
            Name = text;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Member_MainMenu mainMenu = new Member_MainMenu(Name);
            mainMenu.Show();
            this.Hide();

        }
    }
}
