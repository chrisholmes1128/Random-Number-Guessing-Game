// Chris Holmes
// Random Number Generator Form

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandNumGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            GameSetup();

        }

        Random Rand = new Random();
        int secretNum;

        //Creates an intial random number
        void GameSetup()
        {
            secretNum = Rand.Next(1001);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int myGuess = Int32.Parse(textBox1.Text);

            string msg = "";
            
            //Determines if num guessed is secret num
            if (myGuess == secretNum)
            {
                msg = ("You got it!!");
            }
            else if (myGuess > secretNum)
            {
                msg = "Too High!";
            }
            else
                msg = "Too Low";

            textBox1.Text = msg;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        //Clears textbox when clicked inside to type a new number 
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        
        //Clears textbox and creates a new random number to be guessed
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            secretNum = Rand.Next(1001);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }

        //Allows user to press enter rather than clicking on 'check'
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
  
            if (e.KeyChar == (char)Keys.Enter)
            {
               e.Handled = true;
               button2.PerformClick();
            }

        }
    }
}
