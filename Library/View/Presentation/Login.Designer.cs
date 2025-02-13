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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_AdminRole_Login = new System.Windows.Forms.Label();
            this.lbl_AdminEmail_Login = new System.Windows.Forms.Label();
            this.lbl_AdminPassword_Login = new System.Windows.Forms.Label();
            this.txt_AdminRole_Login = new System.Windows.Forms.TextBox();
            this.txt_AdminEmail_Login = new System.Windows.Forms.TextBox();
            this.txt_AdminPassword_Login = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(496, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_AdminPassword_Login);
            this.tabPage1.Controls.Add(this.txt_AdminEmail_Login);
            this.tabPage1.Controls.Add(this.txt_AdminRole_Login);
            this.tabPage1.Controls.Add(this.lbl_AdminPassword_Login);
            this.tabPage1.Controls.Add(this.lbl_AdminEmail_Login);
            this.tabPage1.Controls.Add(this.lbl_AdminRole_Login);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Login";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.lbl_AdminRole_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminRole_Login.Location = new System.Drawing.Point(69, 60);
            this.lbl_AdminRole_Login.Name = "lbl_AdminRole_Login";
            this.lbl_AdminRole_Login.Size = new System.Drawing.Size(52, 25);
            this.lbl_AdminRole_Login.TabIndex = 0;
            this.lbl_AdminRole_Login.Text = "Role:";
            // 
            // lbl_AdminEmail_Login
            // 
            this.lbl_AdminEmail_Login.AutoSize = true;
            this.lbl_AdminEmail_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminEmail_Login.Location = new System.Drawing.Point(69, 137);
            this.lbl_AdminEmail_Login.Name = "lbl_AdminEmail_Login";
            this.lbl_AdminEmail_Login.Size = new System.Drawing.Size(62, 25);
            this.lbl_AdminEmail_Login.TabIndex = 0;
            this.lbl_AdminEmail_Login.Text = "Email:";
            // 
            // lbl_AdminPassword_Login
            // 
            this.lbl_AdminPassword_Login.AutoSize = true;
            this.lbl_AdminPassword_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AdminPassword_Login.Location = new System.Drawing.Point(69, 207);
            this.lbl_AdminPassword_Login.Name = "lbl_AdminPassword_Login";
            this.lbl_AdminPassword_Login.Size = new System.Drawing.Size(95, 25);
            this.lbl_AdminPassword_Login.TabIndex = 0;
            this.lbl_AdminPassword_Login.Text = "Password:";
            // 
            // txt_AdminRole_Login
            // 
            this.txt_AdminRole_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminRole_Login.Location = new System.Drawing.Point(175, 52);
            this.txt_AdminRole_Login.Name = "txt_AdminRole_Login";
            this.txt_AdminRole_Login.Size = new System.Drawing.Size(217, 33);
            this.txt_AdminRole_Login.TabIndex = 1;
            // 
            // txt_AdminEmail_Login
            // 
            this.txt_AdminEmail_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminEmail_Login.Location = new System.Drawing.Point(175, 129);
            this.txt_AdminEmail_Login.Name = "txt_AdminEmail_Login";
            this.txt_AdminEmail_Login.Size = new System.Drawing.Size(217, 33);
            this.txt_AdminEmail_Login.TabIndex = 1;
            // 
            // txt_AdminPassword_Login
            // 
            this.txt_AdminPassword_Login.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AdminPassword_Login.Location = new System.Drawing.Point(175, 199);
            this.txt_AdminPassword_Login.Name = "txt_AdminPassword_Login";
            this.txt_AdminPassword_Login.Size = new System.Drawing.Size(217, 33);
            this.txt_AdminPassword_Login.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 485);
            this.Controls.Add(this.tabControl1);
            this.Name = "Login";
            this.Text = "Login";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_AdminPassword_Login;
        private System.Windows.Forms.TextBox txt_AdminEmail_Login;
        private System.Windows.Forms.TextBox txt_AdminRole_Login;
        private System.Windows.Forms.Label lbl_AdminPassword_Login;
        private System.Windows.Forms.Label lbl_AdminEmail_Login;
        private System.Windows.Forms.Label lbl_AdminRole_Login;
    }
}