namespace Library.View.Presentation
{
    partial class Admin_CategoryBeforeAddingBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_CategoryBeforeAddingBook));
            this.label_BookYearError = new System.Windows.Forms.Label();
            this.label_BookPageError = new System.Windows.Forms.Label();
            this.label_bookGenreError = new System.Windows.Forms.Label();
            this.label_BookAuthorError = new System.Windows.Forms.Label();
            this.label_bookNameError = new System.Windows.Forms.Label();
            this.label_bookIdError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MemberMainMenu_SignIn = new System.Windows.Forms.Label();
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip_choose = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_chooseCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryAutomationDataSet8 = new Library.LibraryAutomationDataSet8();
            this.label_goBack = new System.Windows.Forms.Label();
            this.categoriesTableAdapter = new Library.LibraryAutomationDataSet8TableAdapters.CategoriesTableAdapter();
            this.label_categoryErrorMessage = new System.Windows.Forms.Label();
            this.button_approveCategory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // label_BookYearError
            // 
            this.label_BookYearError.AutoSize = true;
            this.label_BookYearError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookYearError.Location = new System.Drawing.Point(12, 485);
            this.label_BookYearError.Name = "label_BookYearError";
            this.label_BookYearError.Size = new System.Drawing.Size(0, 20);
            this.label_BookYearError.TabIndex = 46;
            // 
            // label_BookPageError
            // 
            this.label_BookPageError.AutoSize = true;
            this.label_BookPageError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookPageError.Location = new System.Drawing.Point(12, 431);
            this.label_BookPageError.Name = "label_BookPageError";
            this.label_BookPageError.Size = new System.Drawing.Size(0, 20);
            this.label_BookPageError.TabIndex = 42;
            // 
            // label_bookGenreError
            // 
            this.label_bookGenreError.AutoSize = true;
            this.label_bookGenreError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookGenreError.Location = new System.Drawing.Point(12, 378);
            this.label_bookGenreError.Name = "label_bookGenreError";
            this.label_bookGenreError.Size = new System.Drawing.Size(0, 20);
            this.label_bookGenreError.TabIndex = 41;
            // 
            // label_BookAuthorError
            // 
            this.label_BookAuthorError.AutoSize = true;
            this.label_BookAuthorError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BookAuthorError.Location = new System.Drawing.Point(12, 328);
            this.label_BookAuthorError.Name = "label_BookAuthorError";
            this.label_BookAuthorError.Size = new System.Drawing.Size(0, 20);
            this.label_BookAuthorError.TabIndex = 43;
            // 
            // label_bookNameError
            // 
            this.label_bookNameError.AutoSize = true;
            this.label_bookNameError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookNameError.Location = new System.Drawing.Point(12, 275);
            this.label_bookNameError.Name = "label_bookNameError";
            this.label_bookNameError.Size = new System.Drawing.Size(0, 20);
            this.label_bookNameError.TabIndex = 44;
            // 
            // label_bookIdError
            // 
            this.label_bookIdError.AutoSize = true;
            this.label_bookIdError.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bookIdError.Location = new System.Drawing.Point(12, 220);
            this.label_bookIdError.Name = "label_bookIdError";
            this.label_bookIdError.Size = new System.Drawing.Size(0, 20);
            this.label_bookIdError.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.label_MemberMainMenu_SignIn);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 41);
            this.panel1.TabIndex = 19;
            // 
            // label_MemberMainMenu_SignIn
            // 
            this.label_MemberMainMenu_SignIn.AutoSize = true;
            this.label_MemberMainMenu_SignIn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberMainMenu_SignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_MemberMainMenu_SignIn.Location = new System.Drawing.Point(284, 8);
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
            this.label_TitleLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_TitleLogin.Location = new System.Drawing.Point(12, 9);
            this.label_TitleLogin.Name = "label_TitleLogin";
            this.label_TitleLogin.Size = new System.Drawing.Size(186, 27);
            this.label_TitleLogin.TabIndex = 2;
            this.label_TitleLogin.Text = "Library Automation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(577, 718);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.toolTip_choose.SetToolTip(this.pictureBox1, "Please Choose A Category To Add A New Book!");
            // 
            // toolTip_choose
            // 
            this.toolTip_choose.BackColor = System.Drawing.Color.LavenderBlush;
            this.toolTip_choose.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Category:";
            // 
            // comboBox_chooseCategory
            // 
            this.comboBox_chooseCategory.DataSource = this.categoriesBindingSource;
            this.comboBox_chooseCategory.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chooseCategory.FormattingEnabled = true;
            this.comboBox_chooseCategory.Location = new System.Drawing.Point(146, 78);
            this.comboBox_chooseCategory.Name = "comboBox_chooseCategory";
            this.comboBox_chooseCategory.Size = new System.Drawing.Size(179, 38);
            this.comboBox_chooseCategory.TabIndex = 49;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.libraryAutomationDataSet8;
            // 
            // libraryAutomationDataSet8
            // 
            this.libraryAutomationDataSet8.DataSetName = "LibraryAutomationDataSet8";
            this.libraryAutomationDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_goBack
            // 
            this.label_goBack.AutoSize = true;
            this.label_goBack.BackColor = System.Drawing.Color.Thistle;
            this.label_goBack.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_goBack.ForeColor = System.Drawing.Color.White;
            this.label_goBack.Location = new System.Drawing.Point(273, 407);
            this.label_goBack.Name = "label_goBack";
            this.label_goBack.Size = new System.Drawing.Size(80, 27);
            this.label_goBack.TabIndex = 50;
            this.label_goBack.Text = "Go Back";
            this.label_goBack.Click += new System.EventHandler(this.label_goBack_Click);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // label_categoryErrorMessage
            // 
            this.label_categoryErrorMessage.AutoSize = true;
            this.label_categoryErrorMessage.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_categoryErrorMessage.Location = new System.Drawing.Point(37, 119);
            this.label_categoryErrorMessage.Name = "label_categoryErrorMessage";
            this.label_categoryErrorMessage.Size = new System.Drawing.Size(0, 19);
            this.label_categoryErrorMessage.TabIndex = 51;
            // 
            // button_approveCategory
            // 
            this.button_approveCategory.BackColor = System.Drawing.Color.Thistle;
            this.button_approveCategory.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_approveCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_approveCategory.Location = new System.Drawing.Point(226, 141);
            this.button_approveCategory.Name = "button_approveCategory";
            this.button_approveCategory.Size = new System.Drawing.Size(110, 37);
            this.button_approveCategory.TabIndex = 52;
            this.button_approveCategory.Text = "Approve";
            this.button_approveCategory.UseVisualStyleBackColor = false;
            this.button_approveCategory.Click += new System.EventHandler(this.button_approveCategory_Click);
            // 
            // Admin_CategoryBeforeAddingBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(365, 461);
            this.Controls.Add(this.button_approveCategory);
            this.Controls.Add(this.label_categoryErrorMessage);
            this.Controls.Add(this.label_goBack);
            this.Controls.Add(this.comboBox_chooseCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_BookYearError);
            this.Controls.Add(this.label_BookPageError);
            this.Controls.Add(this.label_bookGenreError);
            this.Controls.Add(this.label_BookAuthorError);
            this.Controls.Add(this.label_bookNameError);
            this.Controls.Add(this.label_bookIdError);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_CategoryBeforeAddingBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose A Category";
            this.Load += new System.EventHandler(this.Admin_AddBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_BookYearError;
        private System.Windows.Forms.Label label_BookPageError;
        private System.Windows.Forms.Label label_bookGenreError;
        private System.Windows.Forms.Label label_BookAuthorError;
        private System.Windows.Forms.Label label_bookNameError;
        private System.Windows.Forms.Label label_bookIdError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MemberMainMenu_SignIn;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip_choose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_chooseCategory;
        private System.Windows.Forms.Label label_goBack;
        private LibraryAutomationDataSet8 libraryAutomationDataSet8;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private LibraryAutomationDataSet8TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label label_categoryErrorMessage;
        private System.Windows.Forms.Button button_approveCategory;
    }
}