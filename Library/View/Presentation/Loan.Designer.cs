namespace Library.View.Presentation
{
    partial class Loan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Loan_signinPage = new System.Windows.Forms.Label();
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.label_Loan_signinPage);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 3;
            // 
            // label_Loan_signinPage
            // 
            this.label_Loan_signinPage.AutoSize = true;
            this.label_Loan_signinPage.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Loan_signinPage.Location = new System.Drawing.Point(729, 9);
            this.label_Loan_signinPage.Name = "label_Loan_signinPage";
            this.label_Loan_signinPage.Size = new System.Drawing.Size(59, 24);
            this.label_Loan_signinPage.TabIndex = 7;
            this.label_Loan_signinPage.Text = "Sign In";
            this.label_Loan_signinPage.Click += new System.EventHandler(this.label_Loan_signinPage_Click);
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
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Loan";
            this.Text = "Loan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Loan_signinPage;
        private System.Windows.Forms.Label label_TitleLogin;
    }
}