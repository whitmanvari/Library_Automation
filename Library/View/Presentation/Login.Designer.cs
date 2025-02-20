namespace Library.View.Presentation
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_AdminLogin = new System.Windows.Forms.TabPage();
            this.label_errorEmail = new System.Windows.Forms.Label();
            this.label_errorPassword = new System.Windows.Forms.Label();
            this.label_ErrorMessage_LoginPage_AdminPassword = new System.Windows.Forms.Label();
            this.label_ErrorMessage_LoginPage_AdminEmail = new System.Windows.Forms.Label();
            this.label_ErrorMessage_LoginPage_AdminRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_WelcomeMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel_AdminLogin = new System.Windows.Forms.LinkLabel();
            this.button_Enter_LoginPage = new System.Windows.Forms.Button();
            this.txt_AdminPassword_Login = new System.Windows.Forms.TextBox();
            this.txt_AdminEmail_Login = new System.Windows.Forms.TextBox();
            this.lbl_AdminPassword_Login = new System.Windows.Forms.Label();
            this.lbl_AdminEmail_Login = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel_MemberLogin = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Enter_MemberLoginPage = new System.Windows.Forms.Button();
            this.txt_passwordmember = new System.Windows.Forms.TextBox();
            this.txt_emailMember = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_error_password_member = new System.Windows.Forms.Label();
            this.lbl_error_email_member = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Email_UserName_assword_MemberLoginPage = new System.Windows.Forms.Label();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryAutomationDataSet3 = new Library.LibraryAutomationDataSet3();
            this.adminsTableAdapter = new Library.LibraryAutomationDataSet3TableAdapters.AdminsTableAdapter();
            this.btn_ExitLoginPage = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip_clickToSignUp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_clickSignUp = new System.Windows.Forms.ToolTip(this.components);
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.label_LoginPage_Signin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage_AdminLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_AdminLogin);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 407);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage_AdminLogin
            // 
            this.tabPage_AdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_AdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage_AdminLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage_AdminLogin.Controls.Add(this.label_errorEmail);
            this.tabPage_AdminLogin.Controls.Add(this.label_errorPassword);
            this.tabPage_AdminLogin.Controls.Add(this.label_ErrorMessage_LoginPage_AdminPassword);
            this.tabPage_AdminLogin.Controls.Add(this.label_ErrorMessage_LoginPage_AdminEmail);
            this.tabPage_AdminLogin.Controls.Add(this.label_ErrorMessage_LoginPage_AdminRole);
            this.tabPage_AdminLogin.Controls.Add(this.label1);
            this.tabPage_AdminLogin.Controls.Add(this.label_WelcomeMessage);
            this.tabPage_AdminLogin.Controls.Add(this.pictureBox1);
            this.tabPage_AdminLogin.Controls.Add(this.linkLabel_AdminLogin);
            this.tabPage_AdminLogin.Controls.Add(this.button_Enter_LoginPage);
            this.tabPage_AdminLogin.Controls.Add(this.txt_AdminPassword_Login);
            this.tabPage_AdminLogin.Controls.Add(this.txt_AdminEmail_Login);
            this.tabPage_AdminLogin.Controls.Add(this.lbl_AdminPassword_Login);
            this.tabPage_AdminLogin.Controls.Add(this.lbl_AdminEmail_Login);
            this.tabPage_AdminLogin.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabPage_AdminLogin.Location = new System.Drawing.Point(4, 30);
            this.tabPage_AdminLogin.Name = "tabPage_AdminLogin";
            this.tabPage_AdminLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AdminLogin.Size = new System.Drawing.Size(626, 373);
            this.tabPage_AdminLogin.TabIndex = 0;
            this.tabPage_AdminLogin.Text = "Admin Login";
            // 
            // label_errorEmail
            // 
            this.label_errorEmail.AutoSize = true;
            this.label_errorEmail.Location = new System.Drawing.Point(9, 170);
            this.label_errorEmail.Name = "label_errorEmail";
            this.label_errorEmail.Size = new System.Drawing.Size(0, 21);
            this.label_errorEmail.TabIndex = 9;
            // 
            // label_errorPassword
            // 
            this.label_errorPassword.AutoSize = true;
            this.label_errorPassword.Location = new System.Drawing.Point(9, 227);
            this.label_errorPassword.Name = "label_errorPassword";
            this.label_errorPassword.Size = new System.Drawing.Size(0, 21);
            this.label_errorPassword.TabIndex = 9;
            // 
            // label_ErrorMessage_LoginPage_AdminPassword
            // 
            this.label_ErrorMessage_LoginPage_AdminPassword.AutoSize = true;
            this.label_ErrorMessage_LoginPage_AdminPassword.Location = new System.Drawing.Point(7, 261);
            this.label_ErrorMessage_LoginPage_AdminPassword.Name = "label_ErrorMessage_LoginPage_AdminPassword";
            this.label_ErrorMessage_LoginPage_AdminPassword.Size = new System.Drawing.Size(0, 21);
            this.label_ErrorMessage_LoginPage_AdminPassword.TabIndex = 8;
            // 
            // label_ErrorMessage_LoginPage_AdminEmail
            // 
            this.label_ErrorMessage_LoginPage_AdminEmail.AutoSize = true;
            this.label_ErrorMessage_LoginPage_AdminEmail.Location = new System.Drawing.Point(7, 204);
            this.label_ErrorMessage_LoginPage_AdminEmail.Name = "label_ErrorMessage_LoginPage_AdminEmail";
            this.label_ErrorMessage_LoginPage_AdminEmail.Size = new System.Drawing.Size(0, 21);
            this.label_ErrorMessage_LoginPage_AdminEmail.TabIndex = 8;
            // 
            // label_ErrorMessage_LoginPage_AdminRole
            // 
            this.label_ErrorMessage_LoginPage_AdminRole.AutoSize = true;
            this.label_ErrorMessage_LoginPage_AdminRole.Location = new System.Drawing.Point(8, 144);
            this.label_ErrorMessage_LoginPage_AdminRole.Name = "label_ErrorMessage_LoginPage_AdminRole";
            this.label_ErrorMessage_LoginPage_AdminRole.Size = new System.Drawing.Size(0, 21);
            this.label_ErrorMessage_LoginPage_AdminRole.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please Login";
            // 
            // label_WelcomeMessage
            // 
            this.label_WelcomeMessage.AutoSize = true;
            this.label_WelcomeMessage.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WelcomeMessage.Location = new System.Drawing.Point(6, 17);
            this.label_WelcomeMessage.Name = "label_WelcomeMessage";
            this.label_WelcomeMessage.Size = new System.Drawing.Size(385, 35);
            this.label_WelcomeMessage.TabIndex = 6;
            this.label_WelcomeMessage.Text = "Welcome to the Library Automation!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(358, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 386);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel_AdminLogin
            // 
            this.linkLabel_AdminLogin.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.linkLabel_AdminLogin.AutoSize = true;
            this.linkLabel_AdminLogin.LinkColor = System.Drawing.Color.Plum;
            this.linkLabel_AdminLogin.Location = new System.Drawing.Point(155, 283);
            this.linkLabel_AdminLogin.Name = "linkLabel_AdminLogin";
            this.linkLabel_AdminLogin.Size = new System.Drawing.Size(180, 21);
            this.linkLabel_AdminLogin.TabIndex = 3;
            this.linkLabel_AdminLogin.TabStop = true;
            this.linkLabel_AdminLogin.Text = "Don\'t you have an account?";
            this.toolTip_clickSignUp.SetToolTip(this.linkLabel_AdminLogin, "Click to sign up!");
            this.linkLabel_AdminLogin.VisitedLinkColor = System.Drawing.Color.Navy;
            this.linkLabel_AdminLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AdminLogin_LinkClicked);
            // 
            // button_Enter_LoginPage
            // 
            this.button_Enter_LoginPage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enter_LoginPage.Location = new System.Drawing.Point(196, 244);
            this.button_Enter_LoginPage.Name = "button_Enter_LoginPage";
            this.button_Enter_LoginPage.Size = new System.Drawing.Size(139, 36);
            this.button_Enter_LoginPage.TabIndex = 4;
            this.button_Enter_LoginPage.Text = "Enter";
            this.button_Enter_LoginPage.UseVisualStyleBackColor = true;
            this.button_Enter_LoginPage.Click += new System.EventHandler(this.button_Enter_LoginPage_Click);
            // 
            // txt_AdminPassword_Login
            // 
            this.txt_AdminPassword_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminPassword_Login.Location = new System.Drawing.Point(110, 199);
            this.txt_AdminPassword_Login.Name = "txt_AdminPassword_Login";
            this.txt_AdminPassword_Login.Size = new System.Drawing.Size(225, 23);
            this.txt_AdminPassword_Login.TabIndex = 3;
            this.txt_AdminPassword_Login.UseSystemPasswordChar = true;
            this.txt_AdminPassword_Login.TextChanged += new System.EventHandler(this.txt_AdminPassword_Login_TextChanged);
            // 
            // txt_AdminEmail_Login
            // 
            this.txt_AdminEmail_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminEmail_Login.Location = new System.Drawing.Point(110, 142);
            this.txt_AdminEmail_Login.Name = "txt_AdminEmail_Login";
            this.txt_AdminEmail_Login.Size = new System.Drawing.Size(225, 23);
            this.txt_AdminEmail_Login.TabIndex = 2;
            this.txt_AdminEmail_Login.TextChanged += new System.EventHandler(this.txt_AdminEmail_Login_TextChanged);
            // 
            // lbl_AdminPassword_Login
            // 
            this.lbl_AdminPassword_Login.AutoSize = true;
            this.lbl_AdminPassword_Login.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminPassword_Login.Location = new System.Drawing.Point(2, 199);
            this.lbl_AdminPassword_Login.Name = "lbl_AdminPassword_Login";
            this.lbl_AdminPassword_Login.Size = new System.Drawing.Size(93, 28);
            this.lbl_AdminPassword_Login.TabIndex = 0;
            this.lbl_AdminPassword_Login.Text = "Password:";
            // 
            // lbl_AdminEmail_Login
            // 
            this.lbl_AdminEmail_Login.AutoSize = true;
            this.lbl_AdminEmail_Login.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminEmail_Login.Location = new System.Drawing.Point(7, 142);
            this.lbl_AdminEmail_Login.Name = "lbl_AdminEmail_Login";
            this.lbl_AdminEmail_Login.Size = new System.Drawing.Size(63, 28);
            this.lbl_AdminEmail_Login.TabIndex = 0;
            this.lbl_AdminEmail_Login.Text = "Email:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.linkLabel_MemberLogin);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btn_Enter_MemberLoginPage);
            this.tabPage2.Controls.Add(this.txt_passwordmember);
            this.tabPage2.Controls.Add(this.txt_emailMember);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.lbl_error_password_member);
            this.tabPage2.Controls.Add(this.lbl_error_email_member);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label_Email_UserName_assword_MemberLoginPage);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Member Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // linkLabel_MemberLogin
            // 
            this.linkLabel_MemberLogin.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.linkLabel_MemberLogin.AutoSize = true;
            this.linkLabel_MemberLogin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_MemberLogin.LinkColor = System.Drawing.Color.Plum;
            this.linkLabel_MemberLogin.Location = new System.Drawing.Point(105, 295);
            this.linkLabel_MemberLogin.Name = "linkLabel_MemberLogin";
            this.linkLabel_MemberLogin.Size = new System.Drawing.Size(234, 28);
            this.linkLabel_MemberLogin.TabIndex = 10;
            this.linkLabel_MemberLogin.TabStop = true;
            this.linkLabel_MemberLogin.Text = "Don\'t you have an account?";
            this.toolTip_clickToSignUp.SetToolTip(this.linkLabel_MemberLogin, "Click to sign up!");
            this.linkLabel_MemberLogin.VisitedLinkColor = System.Drawing.Color.Navy;
            this.linkLabel_MemberLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_MemberLogin_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Please Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Welcome to the Library Automation!";
            // 
            // btn_Enter_MemberLoginPage
            // 
            this.btn_Enter_MemberLoginPage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter_MemberLoginPage.Location = new System.Drawing.Point(264, 262);
            this.btn_Enter_MemberLoginPage.Name = "btn_Enter_MemberLoginPage";
            this.btn_Enter_MemberLoginPage.Size = new System.Drawing.Size(75, 30);
            this.btn_Enter_MemberLoginPage.TabIndex = 3;
            this.btn_Enter_MemberLoginPage.Text = "Enter";
            this.btn_Enter_MemberLoginPage.UseVisualStyleBackColor = true;
            this.btn_Enter_MemberLoginPage.Click += new System.EventHandler(this.btn_Enter_MemberLoginPage_Click_1);
            // 
            // txt_passwordmember
            // 
            this.txt_passwordmember.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwordmember.Location = new System.Drawing.Point(121, 197);
            this.txt_passwordmember.Name = "txt_passwordmember";
            this.txt_passwordmember.Size = new System.Drawing.Size(218, 26);
            this.txt_passwordmember.TabIndex = 2;
            this.txt_passwordmember.UseSystemPasswordChar = true;
            this.txt_passwordmember.TextChanged += new System.EventHandler(this.textBox_MemberPasswordControl_LoginPage_TextChanged);
            // 
            // txt_emailMember
            // 
            this.txt_emailMember.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailMember.Location = new System.Drawing.Point(121, 150);
            this.txt_emailMember.Name = "txt_emailMember";
            this.txt_emailMember.Size = new System.Drawing.Size(218, 31);
            this.txt_emailMember.TabIndex = 1;
            this.txt_emailMember.TextChanged += new System.EventHandler(this.textBox_MemberEmail_Phone_UserNameControl_LoginPage_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(361, -13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 386);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_error_password_member
            // 
            this.lbl_error_password_member.AutoSize = true;
            this.lbl_error_password_member.Location = new System.Drawing.Point(6, 223);
            this.lbl_error_password_member.Name = "lbl_error_password_member";
            this.lbl_error_password_member.Size = new System.Drawing.Size(0, 21);
            this.lbl_error_password_member.TabIndex = 0;
            // 
            // lbl_error_email_member
            // 
            this.lbl_error_email_member.AutoSize = true;
            this.lbl_error_email_member.Location = new System.Drawing.Point(6, 178);
            this.lbl_error_email_member.Name = "lbl_error_email_member";
            this.lbl_error_email_member.Size = new System.Drawing.Size(0, 21);
            this.lbl_error_email_member.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label_Email_UserName_assword_MemberLoginPage
            // 
            this.label_Email_UserName_assword_MemberLoginPage.AutoSize = true;
            this.label_Email_UserName_assword_MemberLoginPage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email_UserName_assword_MemberLoginPage.Location = new System.Drawing.Point(6, 152);
            this.label_Email_UserName_assword_MemberLoginPage.Name = "label_Email_UserName_assword_MemberLoginPage";
            this.label_Email_UserName_assword_MemberLoginPage.Size = new System.Drawing.Size(63, 28);
            this.label_Email_UserName_assword_MemberLoginPage.TabIndex = 0;
            this.label_Email_UserName_assword_MemberLoginPage.Text = "Email:";
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.libraryAutomationDataSet3;
            // 
            // libraryAutomationDataSet3
            // 
            this.libraryAutomationDataSet3.DataSetName = "LibraryAutomationDataSet3";
            this.libraryAutomationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_ExitLoginPage
            // 
            this.btn_ExitLoginPage.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitLoginPage.Location = new System.Drawing.Point(517, 456);
            this.btn_ExitLoginPage.Name = "btn_ExitLoginPage";
            this.btn_ExitLoginPage.Size = new System.Drawing.Size(97, 44);
            this.btn_ExitLoginPage.TabIndex = 0;
            this.btn_ExitLoginPage.Text = "Exit";
            this.btn_ExitLoginPage.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolTip_clickToSignUp
            // 
            this.toolTip_clickToSignUp.BackColor = System.Drawing.Color.Plum;
            this.toolTip_clickToSignUp.IsBalloon = true;
            // 
            // toolTip_clickSignUp
            // 
            this.toolTip_clickSignUp.BackColor = System.Drawing.Color.Plum;
            this.toolTip_clickSignUp.IsBalloon = true;
            // 
            // label_TitleLogin
            // 
            this.label_TitleLogin.AutoSize = true;
            this.label_TitleLogin.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TitleLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_TitleLogin.Location = new System.Drawing.Point(12, 9);
            this.label_TitleLogin.Name = "label_TitleLogin";
            this.label_TitleLogin.Size = new System.Drawing.Size(186, 25);
            this.label_TitleLogin.TabIndex = 2;
            this.label_TitleLogin.Text = "Library Automation";
            // 
            // label_LoginPage_Signin
            // 
            this.label_LoginPage_Signin.AutoSize = true;
            this.label_LoginPage_Signin.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoginPage_Signin.Location = new System.Drawing.Point(555, 10);
            this.label_LoginPage_Signin.Name = "label_LoginPage_Signin";
            this.label_LoginPage_Signin.Size = new System.Drawing.Size(59, 24);
            this.label_LoginPage_Signin.TabIndex = 7;
            this.label_LoginPage_Signin.Text = "Sign In";
            this.label_LoginPage_Signin.Click += new System.EventHandler(this.label_LoginPage_Signin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.label_LoginPage_Signin);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 41);
            this.panel1.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ExitLoginPage);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_AdminLogin.ResumeLayout(false);
            this.tabPage_AdminLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_AdminLogin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_AdminPassword_Login;
        private System.Windows.Forms.TextBox txt_AdminEmail_Login;
        private System.Windows.Forms.Label lbl_AdminPassword_Login;
        private System.Windows.Forms.Label lbl_AdminEmail_Login;
        private System.Windows.Forms.Button button_Enter_LoginPage;
        private System.Windows.Forms.LinkLabel linkLabel_AdminLogin;
        private LibraryAutomationDataSet3 libraryAutomationDataSet3;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private LibraryAutomationDataSet3TableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.Button btn_ExitLoginPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_error_email_member;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Email_UserName_assword_MemberLoginPage;
        private System.Windows.Forms.Button btn_Enter_MemberLoginPage;
        private System.Windows.Forms.TextBox txt_passwordmember;
        private System.Windows.Forms.TextBox txt_emailMember;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_WelcomeMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_ErrorMessage_LoginPage_AdminPassword;
        private System.Windows.Forms.Label label_ErrorMessage_LoginPage_AdminEmail;
        private System.Windows.Forms.Label label_ErrorMessage_LoginPage_AdminRole;
        private System.Windows.Forms.Label lbl_error_password_member;
        private System.Windows.Forms.LinkLabel linkLabel_MemberLogin;
        private System.Windows.Forms.ToolTip toolTip_clickToSignUp;
        private System.Windows.Forms.ToolTip toolTip_clickSignUp;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.Label label_LoginPage_Signin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_errorEmail;
        private System.Windows.Forms.Label label_errorPassword;
    }
}