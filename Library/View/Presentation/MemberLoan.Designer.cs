﻿namespace Library.View.Presentation
{
    partial class MemberLoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Loan_signinPage = new System.Windows.Forms.Label();
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryAutomationDataSet10 = new Library.LibraryAutomationDataSet10();
            this.booksTableAdapter = new Library.LibraryAutomationDataSet10TableAdapters.BooksTableAdapter();
            this.label_goBackMainMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label_Loan_signinPage);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 43);
            this.panel1.TabIndex = 3;
            // 
            // label_Loan_signinPage
            // 
            this.label_Loan_signinPage.AutoSize = true;
            this.label_Loan_signinPage.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Loan_signinPage.ForeColor = System.Drawing.Color.Cornsilk;
            this.label_Loan_signinPage.Location = new System.Drawing.Point(782, 7);
            this.label_Loan_signinPage.Name = "label_Loan_signinPage";
            this.label_Loan_signinPage.Size = new System.Drawing.Size(90, 33);
            this.label_Loan_signinPage.TabIndex = 7;
            this.label_Loan_signinPage.Text = "Sign In";
            this.label_Loan_signinPage.Click += new System.EventHandler(this.label_Loan_signinPage_Click);
            // 
            // label_TitleLogin
            // 
            this.label_TitleLogin.AutoSize = true;
            this.label_TitleLogin.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleLogin.ForeColor = System.Drawing.Color.Cornsilk;
            this.label_TitleLogin.Location = new System.Drawing.Point(12, 9);
            this.label_TitleLogin.Name = "label_TitleLogin";
            this.label_TitleLogin.Size = new System.Drawing.Size(233, 32);
            this.label_TitleLogin.TabIndex = 2;
            this.label_TitleLogin.Text = "Library Automation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookPublisherDataGridViewTextBoxColumn,
            this.bookPageDataGridViewTextBoxColumn,
            this.bookYearDataGridViewTextBoxColumn,
            this.bookLanguageDataGridViewTextBoxColumn,
            this.bookGenreDataGridViewTextBoxColumn,
            this.bookDescriptionDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.booksBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(17, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(828, 382);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            this.bookAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookAuthorDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookPublisherDataGridViewTextBoxColumn
            // 
            this.bookPublisherDataGridViewTextBoxColumn.DataPropertyName = "BookPublisher";
            this.bookPublisherDataGridViewTextBoxColumn.HeaderText = "BookPublisher";
            this.bookPublisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookPublisherDataGridViewTextBoxColumn.Name = "bookPublisherDataGridViewTextBoxColumn";
            this.bookPublisherDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookPublisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookPageDataGridViewTextBoxColumn
            // 
            this.bookPageDataGridViewTextBoxColumn.DataPropertyName = "BookPage";
            this.bookPageDataGridViewTextBoxColumn.HeaderText = "BookPage";
            this.bookPageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookPageDataGridViewTextBoxColumn.Name = "bookPageDataGridViewTextBoxColumn";
            this.bookPageDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookPageDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookYearDataGridViewTextBoxColumn
            // 
            this.bookYearDataGridViewTextBoxColumn.DataPropertyName = "BookYear";
            this.bookYearDataGridViewTextBoxColumn.HeaderText = "BookYear";
            this.bookYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookYearDataGridViewTextBoxColumn.Name = "bookYearDataGridViewTextBoxColumn";
            this.bookYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookLanguageDataGridViewTextBoxColumn
            // 
            this.bookLanguageDataGridViewTextBoxColumn.DataPropertyName = "BookLanguage";
            this.bookLanguageDataGridViewTextBoxColumn.HeaderText = "BookLanguage";
            this.bookLanguageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookLanguageDataGridViewTextBoxColumn.Name = "bookLanguageDataGridViewTextBoxColumn";
            this.bookLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookLanguageDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookGenreDataGridViewTextBoxColumn
            // 
            this.bookGenreDataGridViewTextBoxColumn.DataPropertyName = "BookGenre";
            this.bookGenreDataGridViewTextBoxColumn.HeaderText = "BookGenre";
            this.bookGenreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookGenreDataGridViewTextBoxColumn.Name = "bookGenreDataGridViewTextBoxColumn";
            this.bookGenreDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookGenreDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookDescriptionDataGridViewTextBoxColumn
            // 
            this.bookDescriptionDataGridViewTextBoxColumn.DataPropertyName = "BookDescription";
            this.bookDescriptionDataGridViewTextBoxColumn.HeaderText = "BookDescription";
            this.bookDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookDescriptionDataGridViewTextBoxColumn.Name = "bookDescriptionDataGridViewTextBoxColumn";
            this.bookDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loanToolStripMenuItem,
            this.checkInDetailToolStripMenuItem,
            this.complaintToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 128);
            // 
            // loanToolStripMenuItem
            // 
            this.loanToolStripMenuItem.Name = "loanToolStripMenuItem";
            this.loanToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.loanToolStripMenuItem.Text = "Loan";
            this.loanToolStripMenuItem.Click += new System.EventHandler(this.loanToolStripMenuItem_Click);
            // 
            // checkInDetailToolStripMenuItem
            // 
            this.checkInDetailToolStripMenuItem.Name = "checkInDetailToolStripMenuItem";
            this.checkInDetailToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.checkInDetailToolStripMenuItem.Text = "Check in detail";
            this.checkInDetailToolStripMenuItem.Click += new System.EventHandler(this.checkInDetailToolStripMenuItem_Click);
            // 
            // complaintToolStripMenuItem
            // 
            this.complaintToolStripMenuItem.Name = "complaintToolStripMenuItem";
            this.complaintToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.complaintToolStripMenuItem.Text = "Complaint";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryAutomationDataSet10;
            // 
            // libraryAutomationDataSet10
            // 
            this.libraryAutomationDataSet10.DataSetName = "LibraryAutomationDataSet10";
            this.libraryAutomationDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label_goBackMainMenu
            // 
            this.label_goBackMainMenu.AutoSize = true;
            this.label_goBackMainMenu.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_goBackMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_goBackMainMenu.Location = new System.Drawing.Point(774, 547);
            this.label_goBackMainMenu.Name = "label_goBackMainMenu";
            this.label_goBackMainMenu.Size = new System.Drawing.Size(100, 33);
            this.label_goBackMainMenu.TabIndex = 2;
            this.label_goBackMainMenu.Text = "Go Back";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Right Click To Loan A Book!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(635, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(863, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_goBackMainMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Loan_signinPage;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryAutomationDataSet10 libraryAutomationDataSet10;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryAutomationDataSet10TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkInDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintToolStripMenuItem;
        private System.Windows.Forms.Label label_goBackMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}