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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_enterClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_enter_form1LibraryAutomation
            // 
            this.button_enter_form1LibraryAutomation.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button_enter_form1LibraryAutomation.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter_form1LibraryAutomation.ForeColor = System.Drawing.Color.White;
            this.button_enter_form1LibraryAutomation.Location = new System.Drawing.Point(373, 433);
            this.button_enter_form1LibraryAutomation.Name = "button_enter_form1LibraryAutomation";
            this.button_enter_form1LibraryAutomation.Size = new System.Drawing.Size(221, 48);
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
            this.pictureBox1.Location = new System.Drawing.Point(-91, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_welcomeMessage
            // 
            this.lbl_welcomeMessage.AutoSize = true;
            this.lbl_welcomeMessage.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcomeMessage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_welcomeMessage.Location = new System.Drawing.Point(139, 45);
            this.lbl_welcomeMessage.Name = "lbl_welcomeMessage";
            this.lbl_welcomeMessage.Size = new System.Drawing.Size(488, 40);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(227, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(518, 459);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // label_enterClick
            // 
            this.label_enterClick.AutoSize = true;
            this.label_enterClick.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enterClick.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label_enterClick.Location = new System.Drawing.Point(457, 95);
            this.label_enterClick.Name = "label_enterClick";
            this.label_enterClick.Size = new System.Drawing.Size(170, 20);
            this.label_enterClick.TabIndex = 4;
            this.label_enterClick.Text = "Click the button to enter!";
            this.label_enterClick.Visible = false;
            // 
            // Form_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(668, 507);
            this.Controls.Add(this.label_enterClick);
            this.Controls.Add(this.lbl_welcomeMessage);
            this.Controls.Add(this.button_enter_form1LibraryAutomation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form_Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Automation";
            this.Load += new System.EventHandler(this.Form_Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enter_form1LibraryAutomation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_welcomeMessage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer_welcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_enterClick;
    }
}

