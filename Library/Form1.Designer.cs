namespace Library
{
    partial class Form_Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welcome));
            this.button_enter_form1LibraryAutomation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_welcomemessage_EntrancePage = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_enter_form1LibraryAutomation
            // 
            this.button_enter_form1LibraryAutomation.BackColor = System.Drawing.Color.LightPink;
            this.button_enter_form1LibraryAutomation.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter_form1LibraryAutomation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_enter_form1LibraryAutomation.Location = new System.Drawing.Point(234, 368);
            this.button_enter_form1LibraryAutomation.Name = "button_enter_form1LibraryAutomation";
            this.button_enter_form1LibraryAutomation.Size = new System.Drawing.Size(185, 41);
            this.button_enter_form1LibraryAutomation.TabIndex = 0;
            this.button_enter_form1LibraryAutomation.Text = "Enter Library";
            this.button_enter_form1LibraryAutomation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_enter_form1LibraryAutomation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_enter_form1LibraryAutomation.UseVisualStyleBackColor = false;
            this.button_enter_form1LibraryAutomation.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(18, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 289);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_welcomemessage_EntrancePage
            // 
            this.label_welcomemessage_EntrancePage.AutoSize = true;
            this.label_welcomemessage_EntrancePage.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcomemessage_EntrancePage.Location = new System.Drawing.Point(28, 9);
            this.label_welcomemessage_EntrancePage.Name = "label_welcomemessage_EntrancePage";
            this.label_welcomemessage_EntrancePage.Size = new System.Drawing.Size(371, 33);
            this.label_welcomemessage_EntrancePage.TabIndex = 2;
            this.label_welcomemessage_EntrancePage.Text = "Welcome to the Library Automation";
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.label_welcomemessage_EntrancePage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_enter_form1LibraryAutomation);
            this.Name = "Form_Welcome";
            this.Text = "Library Automation";
            this.Load += new System.EventHandler(this.Form_Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enter_form1LibraryAutomation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_welcomemessage_EntrancePage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

