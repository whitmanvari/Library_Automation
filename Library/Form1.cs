using Library.DataContext;
using Library.Model.Concrete;
using Library.View.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    
    public partial class Form_Welcome : Form
    {
        private int moveDirection = 1; //left-right direction decider.
        private int moveDistance = 5; //How many pixels will it move?
        private int originalPosition;
        private bool isMoving = false;

        LibraryContext libraryContext = new LibraryContext();
        public Form_Welcome()
        {
            InitializeComponent();
            
            timer_welcome.Interval = 50;
            timer_welcome.Tick += timer_welcome_Tick;
            lbl_welcomeMessage.MouseHover += lbl_welcomeMessage_MouseHover;
            lbl_welcomeMessage.MouseLeave += lbl_welcomeMessage_MouseLeave; 

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Form_Welcome_Load(object sender, EventArgs e)
        {
            originalPosition = lbl_welcomeMessage.Left;
        }

     
       

        private void timer_welcome_Tick(object sender, EventArgs e)
        {
            lbl_welcomeMessage.Left += moveDirection * moveDistance;

            if(lbl_welcomeMessage.Left < originalPosition - 20 || lbl_welcomeMessage.Left > originalPosition +20)
            {
                moveDirection *= -1; //change the direction
            }
        }

        private void lbl_welcomeMessage_MouseHover(object sender, EventArgs e)
        {
            if (!isMoving)
            {
                isMoving = true;
                timer_welcome.Start();
            }
        }

        private void lbl_welcomeMessage_MouseLeave(object sender, EventArgs e)
        {
            timer_welcome.Stop();
            lbl_welcomeMessage.Left = originalPosition;
            isMoving = false;
        }

        private void lbl_welcomeMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
