namespace Library.View.Presentation
{
    partial class MemberLoanCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberLoanCount));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_memberSurname_RegisterPage = new System.Windows.Forms.Label();
            this.label_MemberName_RegisterPage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MemberLoanCount_SignIn = new System.Windows.Forms.Label();
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.nud_ReturnDate = new System.Windows.Forms.NumericUpDown();
            this.dtp_checkoutDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_expectedReturnDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ReturnDate)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(524, 402);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 33);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go Back ";
            // 
            // btn_Loan
            // 
            this.btn_Loan.BackColor = System.Drawing.Color.Black;
            this.btn_Loan.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loan.ForeColor = System.Drawing.Color.White;
            this.btn_Loan.Location = new System.Drawing.Point(99, 293);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(456, 38);
            this.btn_Loan.TabIndex = 45;
            this.btn_Loan.Text = "Loan";
            this.btn_Loan.UseVisualStyleBackColor = false;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(251, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 104);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label_memberSurname_RegisterPage
            // 
            this.label_memberSurname_RegisterPage.AutoSize = true;
            this.label_memberSurname_RegisterPage.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_memberSurname_RegisterPage.Location = new System.Drawing.Point(149, 242);
            this.label_memberSurname_RegisterPage.Name = "label_memberSurname_RegisterPage";
            this.label_memberSurname_RegisterPage.Size = new System.Drawing.Size(130, 30);
            this.label_memberSurname_RegisterPage.TabIndex = 42;
            this.label_memberSurname_RegisterPage.Text = "Loan Period: ";
            // 
            // label_MemberName_RegisterPage
            // 
            this.label_MemberName_RegisterPage.AutoSize = true;
            this.label_MemberName_RegisterPage.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberName_RegisterPage.Location = new System.Drawing.Point(149, 200);
            this.label_MemberName_RegisterPage.Name = "label_MemberName_RegisterPage";
            this.label_MemberName_RegisterPage.Size = new System.Drawing.Size(142, 30);
            this.label_MemberName_RegisterPage.TabIndex = 43;
            this.label_MemberName_RegisterPage.Text = "Chekout Date: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label_MemberLoanCount_SignIn);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 41);
            this.panel1.TabIndex = 29;
            // 
            // label_MemberLoanCount_SignIn
            // 
            this.label_MemberLoanCount_SignIn.AutoSize = true;
            this.label_MemberLoanCount_SignIn.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberLoanCount_SignIn.ForeColor = System.Drawing.Color.White;
            this.label_MemberLoanCount_SignIn.Location = new System.Drawing.Point(542, 7);
            this.label_MemberLoanCount_SignIn.Name = "label_MemberLoanCount_SignIn";
            this.label_MemberLoanCount_SignIn.Size = new System.Drawing.Size(90, 33);
            this.label_MemberLoanCount_SignIn.TabIndex = 7;
            this.label_MemberLoanCount_SignIn.Text = "Sign In";
            // 
            // label_TitleLogin
            // 
            this.label_TitleLogin.AutoSize = true;
            this.label_TitleLogin.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleLogin.ForeColor = System.Drawing.Color.White;
            this.label_TitleLogin.Location = new System.Drawing.Point(12, 9);
            this.label_TitleLogin.Name = "label_TitleLogin";
            this.label_TitleLogin.Size = new System.Drawing.Size(234, 33);
            this.label_TitleLogin.TabIndex = 2;
            this.label_TitleLogin.Text = "Library Automation";
            // 
            // nud_ReturnDate
            // 
            this.nud_ReturnDate.Location = new System.Drawing.Point(297, 251);
            this.nud_ReturnDate.Name = "nud_ReturnDate";
            this.nud_ReturnDate.Size = new System.Drawing.Size(200, 20);
            this.nud_ReturnDate.TabIndex = 2;
            // 
            // dtp_checkoutDate
            // 
            this.dtp_checkoutDate.Location = new System.Drawing.Point(297, 205);
            this.dtp_checkoutDate.Name = "dtp_checkoutDate";
            this.dtp_checkoutDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_checkoutDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expected Return Date: ";
            // 
            // lbl_expectedReturnDate
            // 
            this.lbl_expectedReturnDate.AutoSize = true;
            this.lbl_expectedReturnDate.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_expectedReturnDate.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_expectedReturnDate.Location = new System.Drawing.Point(301, 382);
            this.lbl_expectedReturnDate.Name = "lbl_expectedReturnDate";
            this.lbl_expectedReturnDate.Size = new System.Drawing.Size(0, 30);
            this.lbl_expectedReturnDate.TabIndex = 4;
            // 
            // MemberLoanCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 444);
            this.Controls.Add(this.lbl_expectedReturnDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_checkoutDate);
            this.Controls.Add(this.nud_ReturnDate);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Loan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_memberSurname_RegisterPage);
            this.Controls.Add(this.label_MemberName_RegisterPage);
            this.Controls.Add(this.panel1);
            this.Name = "MemberLoanCount";
            this.Text = "MemberLoanCount";
            this.Load += new System.EventHandler(this.MemberLoanCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ReturnDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_memberSurname_RegisterPage;
        private System.Windows.Forms.Label label_MemberName_RegisterPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MemberLoanCount_SignIn;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.NumericUpDown nud_ReturnDate;
        private System.Windows.Forms.DateTimePicker dtp_checkoutDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_expectedReturnDate;
    }
}