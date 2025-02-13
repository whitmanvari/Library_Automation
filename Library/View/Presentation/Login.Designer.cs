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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_AdminRole_Login = new System.Windows.Forms.Label();
            this.lbl_AdminEmail_Login = new System.Windows.Forms.Label();
            this.lbl_AdminPassword_Login = new System.Windows.Forms.Label();
            this.txt_AdminEmail_Login = new System.Windows.Forms.TextBox();
            this.txt_AdminPassword_Login = new System.Windows.Forms.TextBox();
            this.button_Enter_LoginPage = new System.Windows.Forms.Button();
            this.linkLabel_AdminLogin = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.libraryAutomationDataSet3 = new Library.LibraryAutomationDataSet3();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new Library.LibraryAutomationDataSet3TableAdapters.AdminsTableAdapter();
            this.btn_ExitLoginPage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Email_UserName_assword_MemberLoginPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_errorMessage_Loginpage_MemberEmail = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Enter_MemberLoginPage = new System.Windows.Forms.Button();
            this.label_WelcomeMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_errorMessage_LoginPage_MemberPassword = new System.Windows.Forms.Label();
            this.label_ErrorMessage_LoginPage_AdminRole = new System.Windows.Forms.Label();
            this.label_ErrorMessage_LoginPage_AdminEmail = new System.Windows.Forms.Label();
            this.label_ErrorMessage_LoginPage_AdminPassword = new System.Windows.Forms.Label();
            this.linkLabel_MemberLogin = new System.Windows.Forms.LinkLabel();
            this.toolTip_clickToSignUp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_clickSignUp = new System.Windows.Forms.ToolTip(this.components);
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage_AdminLogin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.tabPage_AdminLogin.Controls.Add(this.label_ErrorMessage_LoginPage_AdminPassword);
            this.tabPage_AdminLogin.Controls.Add(this.label_ErrorMessage_LoginPage_AdminEmail);
            this.tabPage_AdminLogin.Controls.Add(this.label_ErrorMessage_LoginPage_AdminRole);
            this.tabPage_AdminLogin.Controls.Add(this.label1);
            this.tabPage_AdminLogin.Controls.Add(this.label_WelcomeMessage);
            this.tabPage_AdminLogin.Controls.Add(this.pictureBox1);
            this.tabPage_AdminLogin.Controls.Add(this.comboBox1);
            this.tabPage_AdminLogin.Controls.Add(this.linkLabel_AdminLogin);
            this.tabPage_AdminLogin.Controls.Add(this.button_Enter_LoginPage);
            this.tabPage_AdminLogin.Controls.Add(this.txt_AdminPassword_Login);
            this.tabPage_AdminLogin.Controls.Add(this.txt_AdminEmail_Login);
            this.tabPage_AdminLogin.Controls.Add(this.lbl_AdminPassword_Login);
            this.tabPage_AdminLogin.Controls.Add(this.lbl_AdminEmail_Login);
            this.tabPage_AdminLogin.Controls.Add(this.lbl_AdminRole_Login);
            this.tabPage_AdminLogin.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabPage_AdminLogin.Location = new System.Drawing.Point(4, 30);
            this.tabPage_AdminLogin.Name = "tabPage_AdminLogin";
            this.tabPage_AdminLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AdminLogin.Size = new System.Drawing.Size(626, 373);
            this.tabPage_AdminLogin.TabIndex = 0;
            this.tabPage_AdminLogin.Text = "Admin Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.linkLabel_MemberLogin);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btn_Enter_MemberLoginPage);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label_errorMessage_LoginPage_MemberPassword);
            this.tabPage2.Controls.Add(this.label_errorMessage_Loginpage_MemberEmail);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label_Email_UserName_assword_MemberLoginPage);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Member Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_AdminRole_Login
            // 
            this.lbl_AdminRole_Login.AutoSize = true;
            this.lbl_AdminRole_Login.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminRole_Login.Location = new System.Drawing.Point(6, 116);
            this.lbl_AdminRole_Login.Name = "lbl_AdminRole_Login";
            this.lbl_AdminRole_Login.Size = new System.Drawing.Size(51, 28);
            this.lbl_AdminRole_Login.TabIndex = 0;
            this.lbl_AdminRole_Login.Text = "Role:";
            // 
            // lbl_AdminEmail_Login
            // 
            this.lbl_AdminEmail_Login.AutoSize = true;
            this.lbl_AdminEmail_Login.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminEmail_Login.Location = new System.Drawing.Point(6, 176);
            this.lbl_AdminEmail_Login.Name = "lbl_AdminEmail_Login";
            this.lbl_AdminEmail_Login.Size = new System.Drawing.Size(63, 28);
            this.lbl_AdminEmail_Login.TabIndex = 0;
            this.lbl_AdminEmail_Login.Text = "Email:";
            // 
            // lbl_AdminPassword_Login
            // 
            this.lbl_AdminPassword_Login.AutoSize = true;
            this.lbl_AdminPassword_Login.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminPassword_Login.Location = new System.Drawing.Point(1, 233);
            this.lbl_AdminPassword_Login.Name = "lbl_AdminPassword_Login";
            this.lbl_AdminPassword_Login.Size = new System.Drawing.Size(93, 28);
            this.lbl_AdminPassword_Login.TabIndex = 0;
            this.lbl_AdminPassword_Login.Text = "Password:";
            // 
            // txt_AdminEmail_Login
            // 
            this.txt_AdminEmail_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminEmail_Login.Location = new System.Drawing.Point(109, 176);
            this.txt_AdminEmail_Login.Name = "txt_AdminEmail_Login";
            this.txt_AdminEmail_Login.Size = new System.Drawing.Size(225, 23);
            this.txt_AdminEmail_Login.TabIndex = 2;
            // 
            // txt_AdminPassword_Login
            // 
            this.txt_AdminPassword_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminPassword_Login.Location = new System.Drawing.Point(109, 233);
            this.txt_AdminPassword_Login.Name = "txt_AdminPassword_Login";
            this.txt_AdminPassword_Login.Size = new System.Drawing.Size(225, 23);
            this.txt_AdminPassword_Login.TabIndex = 3;
            // 
            // button_Enter_LoginPage
            // 
            this.button_Enter_LoginPage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enter_LoginPage.Location = new System.Drawing.Point(195, 278);
            this.button_Enter_LoginPage.Name = "button_Enter_LoginPage";
            this.button_Enter_LoginPage.Size = new System.Drawing.Size(139, 36);
            this.button_Enter_LoginPage.TabIndex = 4;
            this.button_Enter_LoginPage.Text = "Enter";
            this.button_Enter_LoginPage.UseVisualStyleBackColor = true;
            // 
            // linkLabel_AdminLogin
            // 
            this.linkLabel_AdminLogin.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.linkLabel_AdminLogin.AutoSize = true;
            this.linkLabel_AdminLogin.LinkColor = System.Drawing.Color.Plum;
            this.linkLabel_AdminLogin.Location = new System.Drawing.Point(154, 317);
            this.linkLabel_AdminLogin.Name = "linkLabel_AdminLogin";
            this.linkLabel_AdminLogin.Size = new System.Drawing.Size(180, 21);
            this.linkLabel_AdminLogin.TabIndex = 3;
            this.linkLabel_AdminLogin.TabStop = true;
            this.linkLabel_AdminLogin.Text = "Don\'t you have an account?";
            this.toolTip_clickSignUp.SetToolTip(this.linkLabel_AdminLogin, "Click to sign up!");
            this.linkLabel_AdminLogin.VisitedLinkColor = System.Drawing.Color.Navy;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.adminsBindingSource, "Role", true));
            this.comboBox1.DataSource = this.adminsBindingSource;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // libraryAutomationDataSet3
            // 
            this.libraryAutomationDataSet3.DataSetName = "LibraryAutomationDataSet3";
            this.libraryAutomationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "Admins";
            this.adminsBindingSource.DataSource = this.libraryAutomationDataSet3;
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
            // label_Email_UserName_assword_MemberLoginPage
            // 
            this.label_Email_UserName_assword_MemberLoginPage.AutoSize = true;
            this.label_Email_UserName_assword_MemberLoginPage.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email_UserName_assword_MemberLoginPage.Location = new System.Drawing.Point(6, 152);
            this.label_Email_UserName_assword_MemberLoginPage.Name = "label_Email_UserName_assword_MemberLoginPage";
            this.label_Email_UserName_assword_MemberLoginPage.Size = new System.Drawing.Size(184, 24);
            this.label_Email_UserName_assword_MemberLoginPage.TabIndex = 0;
            this.label_Email_UserName_assword_MemberLoginPage.Text = "Email/Phone/UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // label_errorMessage_Loginpage_MemberEmail
            // 
            this.label_errorMessage_Loginpage_MemberEmail.AutoSize = true;
            this.label_errorMessage_Loginpage_MemberEmail.Location = new System.Drawing.Point(6, 178);
            this.label_errorMessage_Loginpage_MemberEmail.Name = "label_errorMessage_Loginpage_MemberEmail";
            this.label_errorMessage_Loginpage_MemberEmail.Size = new System.Drawing.Size(0, 21);
            this.label_errorMessage_Loginpage_MemberEmail.TabIndex = 0;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(196, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(196, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(179, 26);
            this.textBox2.TabIndex = 2;
            // 
            // btn_Enter_MemberLoginPage
            // 
            this.btn_Enter_MemberLoginPage.Location = new System.Drawing.Point(300, 244);
            this.btn_Enter_MemberLoginPage.Name = "btn_Enter_MemberLoginPage";
            this.btn_Enter_MemberLoginPage.Size = new System.Drawing.Size(75, 30);
            this.btn_Enter_MemberLoginPage.TabIndex = 3;
            this.btn_Enter_MemberLoginPage.Text = "Enter";
            this.btn_Enter_MemberLoginPage.UseVisualStyleBackColor = true;
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
            // label_errorMessage_LoginPage_MemberPassword
            // 
            this.label_errorMessage_LoginPage_MemberPassword.AutoSize = true;
            this.label_errorMessage_LoginPage_MemberPassword.Location = new System.Drawing.Point(6, 223);
            this.label_errorMessage_LoginPage_MemberPassword.Name = "label_errorMessage_LoginPage_MemberPassword";
            this.label_errorMessage_LoginPage_MemberPassword.Size = new System.Drawing.Size(0, 21);
            this.label_errorMessage_LoginPage_MemberPassword.TabIndex = 0;
            // 
            // label_ErrorMessage_LoginPage_AdminRole
            // 
            this.label_ErrorMessage_LoginPage_AdminRole.AutoSize = true;
            this.label_ErrorMessage_LoginPage_AdminRole.Location = new System.Drawing.Point(8, 144);
            this.label_ErrorMessage_LoginPage_AdminRole.Name = "label_ErrorMessage_LoginPage_AdminRole";
            this.label_ErrorMessage_LoginPage_AdminRole.Size = new System.Drawing.Size(0, 21);
            this.label_ErrorMessage_LoginPage_AdminRole.TabIndex = 8;
            // 
            // label_ErrorMessage_LoginPage_AdminEmail
            // 
            this.label_ErrorMessage_LoginPage_AdminEmail.AutoSize = true;
            this.label_ErrorMessage_LoginPage_AdminEmail.Location = new System.Drawing.Point(7, 204);
            this.label_ErrorMessage_LoginPage_AdminEmail.Name = "label_ErrorMessage_LoginPage_AdminEmail";
            this.label_ErrorMessage_LoginPage_AdminEmail.Size = new System.Drawing.Size(0, 21);
            this.label_ErrorMessage_LoginPage_AdminEmail.TabIndex = 8;
            // 
            // label_ErrorMessage_LoginPage_AdminPassword
            // 
            this.label_ErrorMessage_LoginPage_AdminPassword.AutoSize = true;
            this.label_ErrorMessage_LoginPage_AdminPassword.Location = new System.Drawing.Point(7, 261);
            this.label_ErrorMessage_LoginPage_AdminPassword.Name = "label_ErrorMessage_LoginPage_AdminPassword";
            this.label_ErrorMessage_LoginPage_AdminPassword.Size = new System.Drawing.Size(0, 21);
            this.label_ErrorMessage_LoginPage_AdminPassword.TabIndex = 8;
            // 
            // linkLabel_MemberLogin
            // 
            this.linkLabel_MemberLogin.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.linkLabel_MemberLogin.AutoSize = true;
            this.linkLabel_MemberLogin.LinkColor = System.Drawing.Color.Plum;
            this.linkLabel_MemberLogin.Location = new System.Drawing.Point(195, 277);
            this.linkLabel_MemberLogin.Name = "linkLabel_MemberLogin";
            this.linkLabel_MemberLogin.Size = new System.Drawing.Size(180, 21);
            this.linkLabel_MemberLogin.TabIndex = 10;
            this.linkLabel_MemberLogin.TabStop = true;
            this.linkLabel_MemberLogin.Text = "Don\'t you have an account?";
            this.toolTip_clickToSignUp.SetToolTip(this.linkLabel_MemberLogin, "Click to sign up!");
            this.linkLabel_MemberLogin.VisitedLinkColor = System.Drawing.Color.Navy;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(555, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 24);
            this.label19.TabIndex = 7;
            this.label19.Text = "Sign In";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.label19);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label lbl_AdminRole_Login;
        private System.Windows.Forms.Button button_Enter_LoginPage;
        private System.Windows.Forms.LinkLabel linkLabel_AdminLogin;
        private System.Windows.Forms.ComboBox comboBox1;
        private LibraryAutomationDataSet3 libraryAutomationDataSet3;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private LibraryAutomationDataSet3TableAdapters.AdminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.Button btn_ExitLoginPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_errorMessage_Loginpage_MemberEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Email_UserName_assword_MemberLoginPage;
        private System.Windows.Forms.Button btn_Enter_MemberLoginPage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_WelcomeMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_ErrorMessage_LoginPage_AdminPassword;
        private System.Windows.Forms.Label label_ErrorMessage_LoginPage_AdminEmail;
        private System.Windows.Forms.Label label_ErrorMessage_LoginPage_AdminRole;
        private System.Windows.Forms.Label label_errorMessage_LoginPage_MemberPassword;
        private System.Windows.Forms.LinkLabel linkLabel_MemberLogin;
        private System.Windows.Forms.ToolTip toolTip_clickToSignUp;
        private System.Windows.Forms.ToolTip toolTip_clickSignUp;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
    }
}