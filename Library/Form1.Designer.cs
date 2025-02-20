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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Welcome));
            this.button_enter_form1LibraryAutomation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_welcomeMessage = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer_welcome = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_enter_form1LibraryAutomation
            // 
            this.button_enter_form1LibraryAutomation.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_enter_form1LibraryAutomation.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter_form1LibraryAutomation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_enter_form1LibraryAutomation.Location = new System.Drawing.Point(110, 468);
            this.button_enter_form1LibraryAutomation.Name = "button_enter_form1LibraryAutomation";
            this.button_enter_form1LibraryAutomation.Size = new System.Drawing.Size(416, 50);
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
            this.pictureBox1.Location = new System.Drawing.Point(110, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_welcomeMessage
            // 
            this.lbl_welcomeMessage.AutoSize = true;
            this.lbl_welcomeMessage.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeMessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_welcomeMessage.Location = new System.Drawing.Point(63, 56);
            this.lbl_welcomeMessage.Name = "lbl_welcomeMessage";
            this.lbl_welcomeMessage.Size = new System.Drawing.Size(527, 47);
            this.lbl_welcomeMessage.TabIndex = 2;
            this.lbl_welcomeMessage.Text = "Welcome to the Library Automation!";
            this.lbl_welcomeMessage.Click += new System.EventHandler(this.lbl_welcomeMessage_Click);
            this.lbl_welcomeMessage.MouseLeave += new System.EventHandler(this.lbl_welcomeMessage_MouseLeave);
            this.lbl_welcomeMessage.MouseHover += new System.EventHandler(this.lbl_welcomeMessage_MouseHover);
            // 
            // timer_welcome
            // 
            this.timer_welcome.Enabled = true;
            this.timer_welcome.Tick += new System.EventHandler(this.timer_welcome_Tick);
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(639, 540);
            this.Controls.Add(this.lbl_welcomeMessage);
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
        private System.Windows.Forms.Label lbl_welcomeMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer_welcome;
    }
}

