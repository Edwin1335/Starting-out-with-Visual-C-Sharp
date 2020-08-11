using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCounter
{
    public partial class changeCounterForm : Form
    {
        // Constant Values 
        private const double NICKLE = .05;
        private const double DIME = .10;
        private const double QUARTER = .25;
        private const double HALF_DOLLAR = .50;

        // Total Calculation
        private double total = 0;

        public changeCounterForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            total += NICKLE;
            totalLabel.Text = total.ToString("C");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            total += DIME;
            totalLabel.Text = total.ToString("C");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            total += QUARTER;
            totalLabel.Text = total.ToString("C");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            total += HALF_DOLLAR;
            totalLabel.Text = total.ToString("C");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            total = 0;
            totalLabel.Text = total.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
