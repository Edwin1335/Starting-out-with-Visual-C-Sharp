using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseCard(string card)
        {
            if(card == "Ace Card")
            {
                acePictureBox.Visible = true;
                threePictureBox.Visible = false;
                queenPictureBox.Visible = false;
            }
            else if(card == "Three Card")
            {
                acePictureBox.Visible = false;
                threePictureBox.Visible = true;
                queenPictureBox.Visible = false;
            }
            else if (card == "Queen Card")
            {
                acePictureBox.Visible = false;
                threePictureBox.Visible = false;
                queenPictureBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Unpredicted Error");
            }
        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            if(chooseListBox.SelectedIndex != -1)
            {
                ChooseCard(chooseListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please Choose a card");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
