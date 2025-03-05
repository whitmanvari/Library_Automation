namespace Library.View.Presentation
{
    partial class Admin_Add_Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Add_Book));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MemberMainMenu_SignIn = new System.Windows.Forms.Label();
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.textBox_bookName = new System.Windows.Forms.TextBox();
            this.textBox_BookYear = new System.Windows.Forms.TextBox();
            this.textBox_BookPage = new System.Windows.Forms.TextBox();
            this.textBox_BookGenre = new System.Windows.Forms.TextBox();
            this.textBox_BookAuthor = new System.Windows.Forms.TextBox();
            this.textBox_BookLanguage = new System.Windows.Forms.TextBox();
            this.textBox_BookPublisher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBox_Description_book = new System.Windows.Forms.RichTextBox();
            this.linkLabel_goBack = new System.Windows.Forms.LinkLabel();
            this.toolTip_addbook = new System.Windows.Forms.ToolTip(this.components);
            this.button_addBook = new System.Windows.Forms.Button();
            this.checkBox_isactive = new System.Windows.Forms.CheckBox();
            this.label_bookNameError = new System.Windows.Forms.Label();
            this.label_BookAuthorError = new System.Windows.Forms.Label();
            this.label_bookGenreError = new System.Windows.Forms.Label();
            this.label_BookPageError = new System.Windows.Forms.Label();
            this.label_BookYearError = new System.Windows.Forms.Label();
            this.label_BookDescriptionError = new System.Windows.Forms.Label();
            this.label_BookPublisherError = new System.Windows.Forms.Label();
            this.label_BookLanguageError = new System.Windows.Forms.Label();
            this.label_isActiveError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label_MemberMainMenu_SignIn);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 41);
            this.panel1.TabIndex = 5;
            // 
            // label_MemberMainMenu_SignIn
            // 
            this.label_MemberMainMenu_SignIn.AutoSize = true;
            this.label_MemberMainMenu_SignIn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberMainMenu_SignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_MemberMainMenu_SignIn.Location = new System.Drawing.Point(587, 6);
            this.label_MemberMainMenu_SignIn.Name = "label_MemberMainMenu_SignIn";
            this.label_MemberMainMenu_SignIn.Size = new System.Drawing.Size(69, 28);
            this.label_MemberMainMenu_SignIn.TabIndex = 7;
            this.label_MemberMainMenu_SignIn.Text = "Sign In";
            this.label_MemberMainMenu_SignIn.Click += new System.EventHandler(this.label_MemberMainMenu_SignIn_Click);
            // 
            // label_TitleLogin
            // 
            this.label_TitleLogin.AutoSize = true;
            this.label_TitleLogin.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_TitleLogin.Location = new System.Drawing.Point(12, 9);
            this.label_TitleLogin.Name = "label_TitleLogin";
            this.label_TitleLogin.Size = new System.Drawing.Size(186, 27);
            this.label_TitleLogin.TabIndex = 2;
            this.label_TitleLogin.Text = "Library Automation";
            // 
            // textBox_bookName
            // 
            this.textBox_bookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_bookName.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bookName.Location = new System.Drawing.Point(156, 259);
            this.textBox_bookName.Name = "textBox_bookName";
            this.textBox_bookName.Size = new System.Drawing.Size(170, 28);
            this.textBox_bookName.TabIndex = 2;
            this.textBox_bookName.TextChanged += new System.EventHandler(this.textBox_bookName_TextChanged);
            // 
            // textBox_BookYear
            // 
            this.textBox_BookYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_BookYear.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BookYear.Location = new System.Drawing.Point(156, 472);
            this.textBox_BookYear.Name = "textBox_BookYear";
            this.textBox_BookYear.Size = new System.Drawing.Size(170, 28);
            this.textBox_BookYear.TabIndex = 6;
            this.textBox_BookYear.TextChanged += new System.EventHandler(this.textBox_BookYear_TextChanged);
            // 
            // textBox_BookPage
            // 
            this.textBox_BookPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_BookPage.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BookPage.Location = new System.Drawing.Point(156, 418);
            this.textBox_BookPage.Name = "textBox_BookPage";
            this.textBox_BookPage.Size = new System.Drawing.Size(170, 28);
            this.textBox_BookPage.TabIndex = 5;
            this.textBox_BookPage.TextChanged += new System.EventHandler(this.textBox_BookPage_TextChanged);
            // 
            // textBox_BookGenre
            // 
            this.textBox_BookGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_BookGenre.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BookGenre.Location = new System.Drawing.Point(156, 365);
            this.textBox_BookGenre.Name = "textBox_BookGenre";
            this.textBox_BookGenre.Size = new System.Drawing.Size(170, 28);
            this.textBox_BookGenre.TabIndex = 4;
            this.textBox_BookGenre.TextChanged += new System.EventHandler(this.textBox_BookGenre_TextChanged);
            // 
            // textBox_BookAuthor
            // 
            this.textBox_BookAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_BookAuthor.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BookAuthor.Location = new System.Drawing.Point(156, 315);
            this.textBox_BookAuthor.Name = "textBox_BookAuthor";
            this.textBox_BookAuthor.Size = new System.Drawing.Size(170, 28);
            this.textBox_BookAuthor.TabIndex = 3;
            this.textBox_BookAuthor.TextChanged += new System.EventHandler(this.textBox_BookAuthor_TextChanged);
            // 
            // textBox_BookLanguage
            // 
            this.textBox_BookLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_BookLanguage.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BookLanguage.Location = new System.Drawing.Point(489, 57);
            this.textBox_BookLanguage.Name = "textBox_BookLanguage";
            this.textBox_BookLanguage.Size = new System.Drawing.Size(160, 28);
            this.textBox_BookLanguage.TabIndex = 7;
            this.textBox_BookLanguage.TextChanged += new System.EventHandler(this.textBox_BookLanguage_TextChanged);
            // 
            // textBox_BookPublisher
            // 
            this.textBox_BookPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_BookPublisher.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BookPublisher.Location = new System.Drawing.Point(489, 114);
            this.textBox_BookPublisher.Name = "textBox_BookPublisher";
            this.textBox_BookPublisher.Size = new System.Drawing.Size(160, 28);
            this.textBox_BookPublisher.TabIndex = 8;
            this.textBox_BookPublisher.TextChanged += new System.EventHandler(this.textBox_BookPublisher_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(25, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Book Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(25, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book Page:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(25, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Book Year:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Book Description:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 27);
            this.label10.TabIndex = 7;
            this.label10.Text = "Book Publisher:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(315, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 27);
            this.label11.TabIndex = 7;
            this.label11.Text = "Book Language:";
            // 
            // TextBox_Description_book
            // 
            this.TextBox_Description_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TextBox_Description_book.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Description_book.Location = new System.Drawing.Point(489, 172);
            this.TextBox_Description_book.Name = "TextBox_Description_book";
            this.TextBox_Description_book.Size = new System.Drawing.Size(160, 84);
            this.TextBox_Description_book.TabIndex = 12;
            this.TextBox_Description_book.Text = "";
            this.TextBox_Description_book.TextChanged += new System.EventHandler(this.TextBox_Description_book_TextChanged);
            // 
            // linkLabel_goBack
            // 
            this.linkLabel_goBack.ActiveLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel_goBack.AutoSize = true;
            this.linkLabel_goBack.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_goBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel_goBack.Location = new System.Drawing.Point(561, 475);
            this.linkLabel_goBack.Name = "linkLabel_goBack";
            this.linkLabel_goBack.Size = new System.Drawing.Size(95, 31);
            this.linkLabel_goBack.TabIndex = 15;
            this.linkLabel_goBack.TabStop = true;
            this.linkLabel_goBack.Text = "Go Back";
            this.linkLabel_goBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_goBack_LinkClicked);
            // 
            // toolTip_addbook
            // 
            this.toolTip_addbook.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolTip_addbook.IsBalloon = true;
            // 
            // button_addBook
            // 
            this.button_addBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_addBook.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addBook.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button_addBook.Location = new System.Drawing.Point(467, 431);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(189, 41);
            this.button_addBook.TabIndex = 14;
            this.button_addBook.Text = "Add Book";
            this.button_addBook.UseVisualStyleBackColor = false;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // checkBox_isactive
            // 
            this.checkBox_isactive.AutoSize = true;
            this.checkBox_isactive.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_isactive.Location = new System.Drawing.Point(476, 288);
            this.checkBox_isactive.Name = "checkBox_isactive";
            this.checkBox_isactive.Size = new System.Drawing.Size(180, 31);
            this.checkBox_isactive.TabIndex = 13;
            this.checkBox_isactive.Text = "Is Book Available?";
            this.checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // label_bookNameError
            // 
            this.label_bookNameError.AutoSize = true;
            this.label_bookNameError.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookNameError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_bookNameError.Location = new System.Drawing.Point(27, 290);
            this.label_bookNameError.Name = "label_bookNameError";
            this.label_bookNameError.Size = new System.Drawing.Size(0, 27);
            this.label_bookNameError.TabIndex = 14;
            // 
            // label_BookAuthorError
            // 
            this.label_BookAuthorError.AutoSize = true;
            this.label_BookAuthorError.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookAuthorError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_BookAuthorError.Location = new System.Drawing.Point(27, 343);
            this.label_BookAuthorError.Name = "label_BookAuthorError";
            this.label_BookAuthorError.Size = new System.Drawing.Size(0, 27);
            this.label_BookAuthorError.TabIndex = 14;
            // 
            // label_bookGenreError
            // 
            this.label_bookGenreError.AutoSize = true;
            this.label_bookGenreError.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookGenreError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_bookGenreError.Location = new System.Drawing.Point(27, 393);
            this.label_bookGenreError.Name = "label_bookGenreError";
            this.label_bookGenreError.Size = new System.Drawing.Size(0, 27);
            this.label_bookGenreError.TabIndex = 14;
            // 
            // label_BookPageError
            // 
            this.label_BookPageError.AutoSize = true;
            this.label_BookPageError.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookPageError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_BookPageError.Location = new System.Drawing.Point(27, 446);
            this.label_BookPageError.Name = "label_BookPageError";
            this.label_BookPageError.Size = new System.Drawing.Size(0, 27);
            this.label_BookPageError.TabIndex = 14;
            // 
            // label_BookYearError
            // 
            this.label_BookYearError.AutoSize = true;
            this.label_BookYearError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookYearError.ForeColor = System.Drawing.Color.Maroon;
            this.label_BookYearError.Location = new System.Drawing.Point(27, 500);
            this.label_BookYearError.Name = "label_BookYearError";
            this.label_BookYearError.Size = new System.Drawing.Size(0, 20);
            this.label_BookYearError.TabIndex = 14;
            // 
            // label_BookDescriptionError
            // 
            this.label_BookDescriptionError.AutoSize = true;
            this.label_BookDescriptionError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookDescriptionError.ForeColor = System.Drawing.Color.Maroon;
            this.label_BookDescriptionError.Location = new System.Drawing.Point(316, 196);
            this.label_BookDescriptionError.Name = "label_BookDescriptionError";
            this.label_BookDescriptionError.Size = new System.Drawing.Size(0, 20);
            this.label_BookDescriptionError.TabIndex = 14;
            // 
            // label_BookPublisherError
            // 
            this.label_BookPublisherError.AutoSize = true;
            this.label_BookPublisherError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookPublisherError.ForeColor = System.Drawing.Color.Maroon;
            this.label_BookPublisherError.Location = new System.Drawing.Point(316, 145);
            this.label_BookPublisherError.Name = "label_BookPublisherError";
            this.label_BookPublisherError.Size = new System.Drawing.Size(0, 20);
            this.label_BookPublisherError.TabIndex = 14;
            // 
            // label_BookLanguageError
            // 
            this.label_BookLanguageError.AutoSize = true;
            this.label_BookLanguageError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookLanguageError.ForeColor = System.Drawing.Color.Maroon;
            this.label_BookLanguageError.Location = new System.Drawing.Point(316, 85);
            this.label_BookLanguageError.Name = "label_BookLanguageError";
            this.label_BookLanguageError.Size = new System.Drawing.Size(0, 20);
            this.label_BookLanguageError.TabIndex = 14;
            // 
            // label_isActiveError
            // 
            this.label_isActiveError.AutoSize = true;
            this.label_isActiveError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_isActiveError.Location = new System.Drawing.Point(466, 314);
            this.label_isActiveError.Name = "label_isActiveError";
            this.label_isActiveError.Size = new System.Drawing.Size(0, 20);
            this.label_isActiveError.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 197);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Add_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(677, 530);
            this.Controls.Add(this.label_BookLanguageError);
            this.Controls.Add(this.label_BookPublisherError);
            this.Controls.Add(this.label_isActiveError);
            this.Controls.Add(this.label_BookDescriptionError);
            this.Controls.Add(this.label_BookYearError);
            this.Controls.Add(this.label_BookPageError);
            this.Controls.Add(this.label_bookGenreError);
            this.Controls.Add(this.label_BookAuthorError);
            this.Controls.Add(this.label_bookNameError);
            this.Controls.Add(this.checkBox_isactive);
            this.Controls.Add(this.button_addBook);
            this.Controls.Add(this.linkLabel_goBack);
            this.Controls.Add(this.TextBox_Description_book);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_BookAuthor);
            this.Controls.Add(this.textBox_BookGenre);
            this.Controls.Add(this.textBox_BookPage);
            this.Controls.Add(this.textBox_BookPublisher);
            this.Controls.Add(this.textBox_BookYear);
            this.Controls.Add(this.textBox_BookLanguage);
            this.Controls.Add(this.textBox_bookName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin_Add_Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.Admin_Add_Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MemberMainMenu_SignIn;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.TextBox textBox_bookName;
        private System.Windows.Forms.TextBox textBox_BookYear;
        private System.Windows.Forms.TextBox textBox_BookPage;
        private System.Windows.Forms.TextBox textBox_BookGenre;
        private System.Windows.Forms.TextBox textBox_BookAuthor;
        private System.Windows.Forms.TextBox textBox_BookLanguage;
        private System.Windows.Forms.TextBox textBox_BookPublisher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox TextBox_Description_book;
        private System.Windows.Forms.LinkLabel linkLabel_goBack;
        private System.Windows.Forms.ToolTip toolTip_addbook;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.CheckBox checkBox_isactive;
        private System.Windows.Forms.Label label_bookNameError;
        private System.Windows.Forms.Label label_BookAuthorError;
        private System.Windows.Forms.Label label_bookGenreError;
        private System.Windows.Forms.Label label_BookPageError;
        private System.Windows.Forms.Label label_BookYearError;
        private System.Windows.Forms.Label label_BookDescriptionError;
        private System.Windows.Forms.Label label_BookPublisherError;
        private System.Windows.Forms.Label label_BookLanguageError;
        private System.Windows.Forms.Label label_isActiveError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}