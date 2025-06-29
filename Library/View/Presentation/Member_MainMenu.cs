﻿using Library.DataContext;
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
    public partial class Member_MainMenu : Form
    {
        LibraryContext context = new LibraryContext();
        
        string Name;
        int _UserId;
        Category Category;
        public Member_MainMenu(string text, int userId)
        {
            InitializeComponent();
            label_memberName.Text = text;
            Name = label_memberName.Text;
            _UserId = userId;

        }

        private void label_MemberMainMenu_SignIn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void toolStripButton_loanpage_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_bookloan.Visible = true;
        }

        private void toolStripButton_loanpage_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_bookloan.Visible = false;
        }

      
        private void Member_MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_myProfile.Visible = true;
        }

        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_myProfile.Visible = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var member = context.Users.FirstOrDefault(u => u.Name == label_memberName.Text);

            MemberUpdate memberUpdate = new MemberUpdate(member);
            memberUpdate.Show();
            this.Hide();
        }

        private void toolStripButton_categoryList_MouseHover(object sender, EventArgs e)
        {
            toolStripLabel_categoryList.Visible = true;
        }

        private void toolStripButton_categoryList_MouseLeave(object sender, EventArgs e)
        {
            toolStripLabel_categoryList.Visible = false;
        }

        private void toolStripButton_categoryList_Click(object sender, EventArgs e)
        {
            foreach (var item in context.Categories)
            {
                var Category = item.Id;
            }
            Category_List_Member category_List = new Category_List_Member(Name, _UserId);
            category_List.Show();
            this.Hide();
        }

        private void toolStripButton_loanpage_Click(object sender, EventArgs e)
        {
            MemberLoan loan = new MemberLoan(_UserId, Name, Category);
            loan.Show();
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            lbl_selectOperation.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lbl_selectOperation.Visible=false;
        }

        private void toolStripLabel_bookloan_Click(object sender, EventArgs e)
        {

        }
    }
}
