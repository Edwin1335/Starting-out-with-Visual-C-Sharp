using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flip
{
    public partial class cardFlipForm : Form
    {
        public cardFlipForm()
        {
            InitializeComponent();
        }

        private void backCardButton_Click(object sender, EventArgs e)
        {
            backCardPictureBox.Visible = true;
            frontCardPictureBox.Visible = false;
        }

        private void frontCardButton_Click(object sender, EventArgs e)
        {
            frontCardPictureBox.Visible = true;
            backCardPictureBox.Visible = false;
        }
    }
}
