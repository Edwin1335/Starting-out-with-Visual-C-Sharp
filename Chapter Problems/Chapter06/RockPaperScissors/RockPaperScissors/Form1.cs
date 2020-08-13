using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class rockPaperScissorForm : Form
    {
        public rockPaperScissorForm()
        {
            InitializeComponent();
        }

        private int GetComputerAnswer()
        {
            Random rand = new Random();

            return rand.Next(1, 4);
        }

        private int GetPlayerAnswer()
        {
            if(rockradoButton.Checked)
            {
                return 1;
            }
            else if(paperRadioButton.Checked)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private void CheckWinner()
        {
            int playerChoice = GetPlayerAnswer();
            int computerChoice = GetComputerAnswer();
            Console.WriteLine(computerChoice);

            computerChoiceLabel.Visible = true;
            if(computerChoice == 1)
            {
                computerRockPictureBox.Visible = true;
                computerPaperPictureBox.Visible = false;
                computerScissorPictureBox.Visible = false;
            }
            else if (computerChoice == 2)
            {
                computerRockPictureBox.Visible = false;
                computerPaperPictureBox.Visible = true;
                computerScissorPictureBox.Visible = false;
            }
            else
            {
                computerRockPictureBox.Visible = false;
                computerPaperPictureBox.Visible = false;
                computerScissorPictureBox.Visible = true;
            }
            
            if(playerChoice == computerChoice)
            {
                MessageBox.Show("Its a tie");
            }
            else if((playerChoice == 1 && computerChoice == 3) || 
                (playerChoice == 2 && computerChoice == 1) ||
                (playerChoice == 3 && computerChoice == 2))
            {
                MessageBox.Show("CONGRATS: YOU WON !!!");
            }
            else
            {
                MessageBox.Show("You lose ");
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            CheckWinner();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
