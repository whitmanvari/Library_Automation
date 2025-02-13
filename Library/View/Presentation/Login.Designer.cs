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
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage_AdminLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(606, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_AdminLogin
            // 
            this.tabPage_AdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_AdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage_AdminLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.tabPage_AdminLogin.Size = new System.Drawing.Size(598, 373);
            this.tabPage_AdminLogin.TabIndex = 0;
            this.tabPage_AdminLogin.Text = "Admin Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Member Login";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_AdminRole_Login
            // 
            this.lbl_AdminRole_Login.AutoSize = true;
            this.lbl_AdminRole_Login.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminRole_Login.Location = new System.Drawing.Point(6, 111);
            this.lbl_AdminRole_Login.Name = "lbl_AdminRole_Login";
            this.lbl_AdminRole_Login.Size = new System.Drawing.Size(61, 33);
            this.lbl_AdminRole_Login.TabIndex = 0;
            this.lbl_AdminRole_Login.Text = "Role:";
            // 
            // lbl_AdminEmail_Login
            // 
            this.lbl_AdminEmail_Login.AutoSize = true;
            this.lbl_AdminEmail_Login.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminEmail_Login.Location = new System.Drawing.Point(6, 176);
            this.lbl_AdminEmail_Login.Name = "lbl_AdminEmail_Login";
            this.lbl_AdminEmail_Login.Size = new System.Drawing.Size(74, 33);
            this.lbl_AdminEmail_Login.TabIndex = 0;
            this.lbl_AdminEmail_Login.Text = "Email:";
            // 
            // lbl_AdminPassword_Login
            // 
            this.lbl_AdminPassword_Login.AutoSize = true;
            this.lbl_AdminPassword_Login.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminPassword_Login.Location = new System.Drawing.Point(6, 238);
            this.lbl_AdminPassword_Login.Name = "lbl_AdminPassword_Login";
            this.lbl_AdminPassword_Login.Size = new System.Drawing.Size(112, 33);
            this.lbl_AdminPassword_Login.TabIndex = 0;
            this.lbl_AdminPassword_Login.Text = "Password:";
            // 
            // txt_AdminEmail_Login
            // 
            this.txt_AdminEmail_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminEmail_Login.Location = new System.Drawing.Point(124, 176);
            this.txt_AdminEmail_Login.Name = "txt_AdminEmail_Login";
            this.txt_AdminEmail_Login.Size = new System.Drawing.Size(225, 23);
            this.txt_AdminEmail_Login.TabIndex = 1;
            // 
            // txt_AdminPassword_Login
            // 
            this.txt_AdminPassword_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminPassword_Login.Location = new System.Drawing.Point(124, 248);
            this.txt_AdminPassword_Login.Name = "txt_AdminPassword_Login";
            this.txt_AdminPassword_Login.Size = new System.Drawing.Size(225, 23);
            this.txt_AdminPassword_Login.TabIndex = 1;
            // 
            // button_Enter_LoginPage
            // 
            this.button_Enter_LoginPage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enter_LoginPage.Location = new System.Drawing.Point(210, 290);
            this.button_Enter_LoginPage.Name = "button_Enter_LoginPage";
            this.button_Enter_LoginPage.Size = new System.Drawing.Size(139, 36);
            this.button_Enter_LoginPage.TabIndex = 2;
            this.button_Enter_LoginPage.Text = "Enter";
            this.button_Enter_LoginPage.UseVisualStyleBackColor = true;
            // 
            // linkLabel_AdminLogin
            // 
            this.linkLabel_AdminLogin.ActiveLinkColor = System.Drawing.Color.DarkMagenta;
            this.linkLabel_AdminLogin.AutoSize = true;
            this.linkLabel_AdminLogin.LinkColor = System.Drawing.Color.Plum;
            this.linkLabel_AdminLogin.Location = new System.Drawing.Point(169, 329);
            this.linkLabel_AdminLogin.Name = "linkLabel_AdminLogin";
            this.linkLabel_AdminLogin.Size = new System.Drawing.Size(180, 21);
            this.linkLabel_AdminLogin.TabIndex = 3;
            this.linkLabel_AdminLogin.TabStop = true;
            this.linkLabel_AdminLogin.Text = "Don\'t you have an account?";
            this.linkLabel_AdminLogin.VisitedLinkColor = System.Drawing.Color.Navy;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.adminsBindingSource, "Role", true));
            this.comboBox1.DataSource = this.adminsBindingSource;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 23);
            this.comboBox1.TabIndex = 4;
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
            this.btn_ExitLoginPage.TabIndex = 1;
            this.btn_ExitLoginPage.Text = "Exit";
            this.btn_ExitLoginPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(355, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 386);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
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
            ((System.ComponentModel.ISupportInitialize)(this.libraryAutomationDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}