namespace Library.View.Presentation
{
    partial class Member_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member_MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_MemberMainMenu_SignIn = new System.Windows.Forms.Label();
            this.label_TitleLogin = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_booklist = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_booklist = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_loanpage = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_bookloan = new System.Windows.Forms.ToolStripLabel();
            this.toolTip_booklist = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.label_MemberMainMenu_SignIn);
            this.panel1.Controls.Add(this.label_TitleLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 3;
            // 
            // label_MemberMainMenu_SignIn
            // 
            this.label_MemberMainMenu_SignIn.AutoSize = true;
            this.label_MemberMainMenu_SignIn.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MemberMainMenu_SignIn.Location = new System.Drawing.Point(729, 10);
            this.label_MemberMainMenu_SignIn.Name = "label_MemberMainMenu_SignIn";
            this.label_MemberMainMenu_SignIn.Size = new System.Drawing.Size(59, 24);
            this.label_MemberMainMenu_SignIn.TabIndex = 7;
            this.label_MemberMainMenu_SignIn.Text = "Sign In";
            this.label_MemberMainMenu_SignIn.Click += new System.EventHandler(this.label_MemberMainMenu_SignIn_Click);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_booklist,
            this.toolStripLabel_booklist,
            this.toolStripSeparator1,
            this.toolStripButton_loanpage,
            this.toolStripLabel_bookloan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 41);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_booklist
            // 
            this.toolStripButton_booklist.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_booklist.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_booklist.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_booklist.Image")));
            this.toolStripButton_booklist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_booklist.Name = "toolStripButton_booklist";
            this.toolStripButton_booklist.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton_booklist.Text = "Show Book List";
            this.toolStripButton_booklist.Click += new System.EventHandler(this.toolStripButton_booklist_Click);
            this.toolStripButton_booklist.MouseLeave += new System.EventHandler(this.toolStripButton_booklist_MouseLeave);
            this.toolStripButton_booklist.MouseHover += new System.EventHandler(this.toolStripButton_booklist_MouseHover);
            // 
            // toolStripLabel_booklist
            // 
            this.toolStripLabel_booklist.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_booklist.Name = "toolStripLabel_booklist";
            this.toolStripLabel_booklist.Size = new System.Drawing.Size(93, 30);
            this.toolStripLabel_booklist.Text = "Book List";
            this.toolStripLabel_booklist.Visible = false;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton_loanpage
            // 
            this.toolStripButton_loanpage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_loanpage.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton_loanpage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_loanpage.Image")));
            this.toolStripButton_loanpage.ImageTransparentColor = System.Drawing.Color.Thistle;
            this.toolStripButton_loanpage.Name = "toolStripButton_loanpage";
            this.toolStripButton_loanpage.Size = new System.Drawing.Size(23, 30);
            this.toolStripButton_loanpage.Text = "Book Loan";
            this.toolStripButton_loanpage.ToolTipText = "Book Loan Page";
            this.toolStripButton_loanpage.MouseLeave += new System.EventHandler(this.toolStripButton_loanpage_MouseLeave);
            this.toolStripButton_loanpage.MouseHover += new System.EventHandler(this.toolStripButton_loanpage_MouseHover);
            // 
            // toolStripLabel_bookloan
            // 
            this.toolStripLabel_bookloan.Font = new System.Drawing.Font("Segoe Print", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_bookloan.Name = "toolStripLabel_bookloan";
            this.toolStripLabel_bookloan.Size = new System.Drawing.Size(104, 30);
            this.toolStripLabel_bookloan.Text = "Book Loan";
            this.toolStripLabel_bookloan.Visible = false;
            // 
            // Member_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Member_MainMenu";
            this.Text = "Member_MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_MemberMainMenu_SignIn;
        private System.Windows.Forms.Label label_TitleLogin;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_booklist;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_booklist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_loanpage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_bookloan;
        private System.Windows.Forms.ToolTip toolTip_booklist;
    }
}