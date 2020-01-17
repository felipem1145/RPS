using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSProject
{
    public partial class RPS : Form
    {
        public RPS()
        {
            InitializeComponent();
        }

        int playerSelection;
        private void button3_Click(object sender, EventArgs e)
        {
            playerSelection = 3;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rock_Click(object sender, EventArgs e)
        {
            playerSelection = 1;
        }

        private void Paper_Click(object sender, EventArgs e)
        {
            playerSelection = 2;
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num = RandomNumber(1, 4);

            if (playerSelection == 0)
            {
                MessageBox.Show("Please select an option");
                return;
            }
            //Computer Choice

            if (num == 1)
            {
                txtComputerChoice.Text = "Rock";
            }else if(num == 2)
            {
                txtComputerChoice.Text = "Paper";
            }
            else
            {
                txtComputerChoice.Text = "Scissors";
            }

            //Comparisson


            int dif = num - playerSelection;
            // int dif2 = num - playerSelection;

            if (playerSelection == num)
            {
                txtResult.Text = "DRAW";
            }
            else if (playerSelection > num)
            {
                txtResult.Text = "YOU WON!";

            }
            else if(playerSelection < num &  dif > 1)
            {
                txtResult.Text = "YOU WON!";
            }
            else //if(num < playerSelection & dif2 > 1 )
            {
                txtResult.Text = "COMPUTER WON.";
            }

            playerSelection = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
