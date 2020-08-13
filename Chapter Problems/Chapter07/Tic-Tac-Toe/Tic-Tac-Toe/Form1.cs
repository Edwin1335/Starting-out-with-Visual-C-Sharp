using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class ticTacToeForm : Form
    {
        public ticTacToeForm()
        {
            InitializeComponent();
        }

        public void Display(char[,] myArray)
        {
            topLeftlabel.Text = myArray[0,0].ToString();
            topCenterLabel.Text = myArray[0, 1].ToString();
            topRightLabel.Text = myArray[0, 2].ToString();
            centerLeftLabel.Text = myArray[1, 0].ToString();
            centerCenterLabel.Text = myArray[1, 1].ToString();
            centerRightLabel.Text = myArray[1, 2].ToString();
            bottomLeftLabel.Text = myArray[2, 0].ToString();
            bottomventerLabel.Text = myArray[2, 1].ToString();
            bottomRightLabel.Text = myArray[2, 2].ToString();
        }

        public void DisplayWinner(char[,] myArray)
        {
            for(int i = 0; i < myArray.GetLength(0); i++)
            {
                if(myArray[i, 0] == myArray[i,1] && myArray[i, 2] == myArray[i,1])
                {
                    MessageBox.Show("Player " + myArray[i, 0].ToString() + " has WON");
                    return;
                }
                if(myArray[0, i] == myArray[1, i] && myArray[2, i] == myArray[1, i])
                {
                    MessageBox.Show("Player " + myArray[0, i].ToString() + " has WON");
                    return;
                }
            }

            // Check diagnal win
            if(myArray[0, 0] == myArray[1, 1] && myArray[1, 1] == myArray[2, 2])
            {
                MessageBox.Show("Player " + myArray[0, 0].ToString() + " has WON");
                return;
            }
            if (myArray[0, 2] == myArray[1, 1] && myArray[1, 1] == myArray[2, 0])
            {
                MessageBox.Show("Player " + myArray[0, 2].ToString() + " has WON");
                return;
            }

            MessageBox.Show("Its a tie!!");
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            const int COL = 3;
            const int ROW = 3;
            Random rand = new Random();

            char[,] ticChar = new char[ROW, COL];

            for (int i = 0; i < ROW; i++)
            {
                for(int j = 0; j < COL; j++)
                {
                    if (rand.Next(1, 3) == 1)
                    {
                        ticChar[i, j] = 'X';
                    }
                    else
                    {
                        ticChar[i, j] = 'O';
                    }
                }
            }

            Display(ticChar);
            DisplayWinner(ticChar);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            topLeftlabel.Text = "";
            topCenterLabel.Text = "";
            topRightLabel.Text = "";
            centerLeftLabel.Text = "";
            centerCenterLabel.Text = "";
            centerRightLabel.Text = "";
            bottomLeftLabel.Text = "";
            bottomventerLabel.Text = "";
            bottomRightLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
