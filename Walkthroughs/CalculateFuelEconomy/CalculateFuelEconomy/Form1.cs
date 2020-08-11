using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateFuelEconomy
{
    public partial class clalculateFuleEconomyForm : Form
    {
        public clalculateFuleEconomyForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Store the miles, gallons and MilesPerGallon 
            double miles, gallons, MPG;
            miles = double.Parse(milesTextBox.Text);
            gallons = double.Parse(gallonsTextBox.Text);

            // Perform arithmatic operation to calcualte MPG
            MPG = miles / gallons;

            // Assign the MPG label to the calcuated MPG
            mpgLabel.Text = MPG.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
