﻿namespace Library.View.Presentation
{
    partial class BookList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryAutomationDataSet6 = new Library.LibraryAutomationDataSet6();
            this.booksTableAdapter = new Library.LibraryAutomationDataSet6TableAdapters.BooksTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MemberMainMenu_SignIn = new System.Windows.Forms.Label();
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_booklist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booklist)).BeginInit();
            this.SuspendLayout();
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryAutomationDataSet6;
            // 
            // libraryAutomationDataSet6
            // 
            this.libraryAutomationDataSet6.DataSetName = "LibraryAutomationDataSet6";
            this.libraryAutomationDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(849, 564);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Go Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label_MemberMainMenu_SignIn);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 40);
            this.panel1.TabIndex = 6;
            // 
            // label_MemberMainMenu_SignIn
            // 
            this.label_MemberMainMenu_SignIn.AutoSize = true;
            this.label_MemberMainMenu_SignIn.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberMainMenu_SignIn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_MemberMainMenu_SignIn.Location = new System.Drawing.Point(857, 13);
            this.label_MemberMainMenu_SignIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MemberMainMenu_SignIn.Name = "label_MemberMainMenu_SignIn";
            this.label_MemberMainMenu_SignIn.Size = new System.Drawing.Size(72, 27);
            this.label_MemberMainMenu_SignIn.TabIndex = 7;
            this.label_MemberMainMenu_SignIn.Text = "Sign In";
            this.label_MemberMainMenu_SignIn.Click += new System.EventHandler(this.label_MemberMainMenu_SignIn_Click);
            // 
            // label_TitleLogin
            // 
            this.label_TitleLogin.AutoSize = true;
            this.label_TitleLogin.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_TitleLogin.Location = new System.Drawing.Point(16, 12);
            this.label_TitleLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TitleLogin.Name = "label_TitleLogin";
            this.label_TitleLogin.Size = new System.Drawing.Size(186, 27);
            this.label_TitleLogin.TabIndex = 2;
            this.label_TitleLogin.Text = "Library Automation";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Width = 70;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Width = 108;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            this.createdDateDataGridViewTextBoxColumn.Width = 121;
            // 
            // bookDescriptionDataGridViewTextBoxColumn
            // 
            this.bookDescriptionDataGridViewTextBoxColumn.DataPropertyName = "BookDescription";
            this.bookDescriptionDataGridViewTextBoxColumn.HeaderText = "BookDescription";
            this.bookDescriptionDataGridViewTextBoxColumn.Name = "bookDescriptionDataGridViewTextBoxColumn";
            this.bookDescriptionDataGridViewTextBoxColumn.Width = 148;
            // 
            // bookGenreDataGridViewTextBoxColumn
            // 
            this.bookGenreDataGridViewTextBoxColumn.DataPropertyName = "BookGenre";
            this.bookGenreDataGridViewTextBoxColumn.HeaderText = "BookGenre";
            this.bookGenreDataGridViewTextBoxColumn.Name = "bookGenreDataGridViewTextBoxColumn";
            this.bookGenreDataGridViewTextBoxColumn.Width = 107;
            // 
            // bookLanguageDataGridViewTextBoxColumn
            // 
            this.bookLanguageDataGridViewTextBoxColumn.DataPropertyName = "BookLanguage";
            this.bookLanguageDataGridViewTextBoxColumn.HeaderText = "BookLanguage";
            this.bookLanguageDataGridViewTextBoxColumn.Name = "bookLanguageDataGridViewTextBoxColumn";
            this.bookLanguageDataGridViewTextBoxColumn.Width = 133;
            // 
            // bookYearDataGridViewTextBoxColumn
            // 
            this.bookYearDataGridViewTextBoxColumn.DataPropertyName = "BookYear";
            this.bookYearDataGridViewTextBoxColumn.HeaderText = "BookYear";
            this.bookYearDataGridViewTextBoxColumn.Name = "bookYearDataGridViewTextBoxColumn";
            this.bookYearDataGridViewTextBoxColumn.Width = 96;
            // 
            // bookPageDataGridViewTextBoxColumn
            // 
            this.bookPageDataGridViewTextBoxColumn.DataPropertyName = "BookPage";
            this.bookPageDataGridViewTextBoxColumn.HeaderText = "BookPage";
            this.bookPageDataGridViewTextBoxColumn.Name = "bookPageDataGridViewTextBoxColumn";
            // 
            // bookPublisherDataGridViewTextBoxColumn
            // 
            this.bookPublisherDataGridViewTextBoxColumn.DataPropertyName = "BookPublisher";
            this.bookPublisherDataGridViewTextBoxColumn.HeaderText = "BookPublisher";
            this.bookPublisherDataGridViewTextBoxColumn.Name = "bookPublisherDataGridViewTextBoxColumn";
            this.bookPublisherDataGridViewTextBoxColumn.Width = 133;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            this.bookAuthorDataGridViewTextBoxColumn.Width = 118;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 106;
            // 
            // dataGridView_booklist
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_booklist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_booklist.AutoGenerateColumns = false;
            this.dataGridView_booklist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_booklist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView_booklist.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView_booklist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_booklist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_booklist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView_booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_booklist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView_booklist.DataSource = this.booksBindingSource;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_booklist.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView_booklist.GridColor = System.Drawing.Color.DarkOrchid;
            this.dataGridView_booklist.Location = new System.Drawing.Point(0, 61);
            this.dataGridView_booklist.Name = "dataGridView_booklist";
            this.dataGridView_booklist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_booklist.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView_booklist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_booklist.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView_booklist.Size = new System.Drawing.Size(942, 500);
            this.dataGridView_booklist.TabIndex = 4;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(941, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_booklist);
            this.Name = "BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookList";
            this.Load += new System.EventHandler(this.BookList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryAutomationDataSet6 libraryAutomationDataSet6;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryAutomationDataSet6TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MemberMainMenu_SignIn;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView_booklist;
    }
}