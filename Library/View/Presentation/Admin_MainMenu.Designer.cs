﻿namespace Library.View.Presentation
{
    partial class Admin_MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MemberMainMenu_SignIn = new System.Windows.Forms.Label();
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_bookCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_bookCategory_Admin = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_adminUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_adminUpdate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_addBook = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_AddCategory = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.toolTip_welcome = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_selectOperation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label_MemberMainMenu_SignIn);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 41);
            this.panel1.TabIndex = 4;
            // 
            // label_MemberMainMenu_SignIn
            // 
            this.label_MemberMainMenu_SignIn.AutoSize = true;
            this.label_MemberMainMenu_SignIn.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberMainMenu_SignIn.ForeColor = System.Drawing.Color.Black;
            this.label_MemberMainMenu_SignIn.Location = new System.Drawing.Point(463, 9);
            this.label_MemberMainMenu_SignIn.Name = "label_MemberMainMenu_SignIn";
            this.label_MemberMainMenu_SignIn.Size = new System.Drawing.Size(90, 33);
            this.label_MemberMainMenu_SignIn.TabIndex = 7;
            this.label_MemberMainMenu_SignIn.Text = "Sign In";
            this.label_MemberMainMenu_SignIn.Click += new System.EventHandler(this.label_MemberMainMenu_SignIn_Click);
            // 
            // label_TitleLogin
            // 
            this.label_TitleLogin.AutoSize = true;
            this.label_TitleLogin.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleLogin.ForeColor = System.Drawing.Color.Black;
            this.label_TitleLogin.Location = new System.Drawing.Point(12, 9);
            this.label_TitleLogin.Name = "label_TitleLogin";
            this.label_TitleLogin.Size = new System.Drawing.Size(234, 33);
            this.label_TitleLogin.TabIndex = 2;
            this.label_TitleLogin.Text = "Library Automation";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_bookCategory,
            this.toolStripLabel_bookCategory_Admin,
            this.toolStripSeparator2,
            this.toolStripButton_adminUpdate,
            this.toolStripLabel_adminUpdate,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripLabel_addBook,
            this.toolStripSeparator4,
            this.toolStripButton2,
            this.toolStripLabel_AddCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 41);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(547, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_bookCategory
            // 
            this.toolStripButton_bookCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_bookCategory.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_bookCategory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_bookCategory.Image")));
            this.toolStripButton_bookCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_bookCategory.Name = "toolStripButton_bookCategory";
            this.toolStripButton_bookCategory.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_bookCategory.Text = "Book Category";
            this.toolStripButton_bookCategory.Click += new System.EventHandler(this.toolStripButton_bookCategory_Click);
            this.toolStripButton_bookCategory.MouseLeave += new System.EventHandler(this.toolStripButton2_MouseLeave);
            this.toolStripButton_bookCategory.MouseHover += new System.EventHandler(this.toolStripButton2_MouseHover);
            // 
            // toolStripLabel_bookCategory_Admin
            // 
            this.toolStripLabel_bookCategory_Admin.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_bookCategory_Admin.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.toolStripLabel_bookCategory_Admin.Name = "toolStripLabel_bookCategory_Admin";
            this.toolStripLabel_bookCategory_Admin.Size = new System.Drawing.Size(122, 24);
            this.toolStripLabel_bookCategory_Admin.Text = "Book Category";
            this.toolStripLabel_bookCategory_Admin.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton_adminUpdate
            // 
            this.toolStripButton_adminUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_adminUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_adminUpdate.Image")));
            this.toolStripButton_adminUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_adminUpdate.Name = "toolStripButton_adminUpdate";
            this.toolStripButton_adminUpdate.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton_adminUpdate.Text = "Show Admin Information Update Page";
            this.toolStripButton_adminUpdate.Click += new System.EventHandler(this.toolStripButton_adminUpdate_Click);
            this.toolStripButton_adminUpdate.MouseLeave += new System.EventHandler(this.toolStripButton_adminUpdate_MouseLeave);
            this.toolStripButton_adminUpdate.MouseHover += new System.EventHandler(this.toolStripButton_adminUpdate_MouseHover);
            // 
            // toolStripLabel_adminUpdate
            // 
            this.toolStripLabel_adminUpdate.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_adminUpdate.Name = "toolStripLabel_adminUpdate";
            this.toolStripLabel_adminUpdate.Size = new System.Drawing.Size(130, 24);
            this.toolStripLabel_adminUpdate.Text = "Admin Update";
            this.toolStripLabel_adminUpdate.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Add Book";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton1.MouseLeave += new System.EventHandler(this.toolStripButton1_MouseLeave_1);
            this.toolStripButton1.MouseHover += new System.EventHandler(this.toolStripButton1_MouseHover_1);
            // 
            // toolStripLabel_addBook
            // 
            this.toolStripLabel_addBook.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_addBook.Name = "toolStripLabel_addBook";
            this.toolStripLabel_addBook.Size = new System.Drawing.Size(89, 24);
            this.toolStripLabel_addBook.Text = "Add Book";
            this.toolStripLabel_addBook.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Add Category";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.toolStripButton2.MouseLeave += new System.EventHandler(this.toolStripButton2_MouseLeave_1);
            this.toolStripButton2.MouseHover += new System.EventHandler(this.toolStripButton2_MouseHover_1);
            // 
            // toolStripLabel_AddCategory
            // 
            this.toolStripLabel_AddCategory.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_AddCategory.Name = "toolStripLabel_AddCategory";
            this.toolStripLabel_AddCategory.Size = new System.Drawing.Size(119, 24);
            this.toolStripLabel_AddCategory.Text = "Add Category";
            this.toolStripLabel_AddCategory.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(195, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 336);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.toolTip_welcome.SetToolTip(this.pictureBox1, "Let\'s add some books!");
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 57);
            this.label2.TabIndex = 13;
            this.label2.Text = "Welcome ";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(14, 182);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 64);
            this.label_name.TabIndex = 15;
            // 
            // toolTip_welcome
            // 
            this.toolTip_welcome.IsBalloon = true;
            // 
            // lbl_selectOperation
            // 
            this.lbl_selectOperation.AutoSize = true;
            this.lbl_selectOperation.BackColor = System.Drawing.Color.Tan;
            this.lbl_selectOperation.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectOperation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_selectOperation.Location = new System.Drawing.Point(17, 451);
            this.lbl_selectOperation.Name = "lbl_selectOperation";
            this.lbl_selectOperation.Size = new System.Drawing.Size(518, 44);
            this.lbl_selectOperation.TabIndex = 18;
            this.lbl_selectOperation.Text = "Select one of the operations below!";
            this.lbl_selectOperation.Visible = false;
            this.lbl_selectOperation.Click += new System.EventHandler(this.lbl_selectOperation_Click);
            // 
            // Admin_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(547, 517);
            this.Controls.Add(this.lbl_selectOperation);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Admin_MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MemberMainMenu_SignIn;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_bookCategory;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_bookCategory_Admin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_adminUpdate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_adminUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ToolTip toolTip_welcome;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_addBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_AddCategory;
        private System.Windows.Forms.Label lbl_selectOperation;
    }
}