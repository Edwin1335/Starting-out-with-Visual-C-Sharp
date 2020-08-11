using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingFuelEconomy
{
    public partial class fuelEconomyForm : Form
    {
        public fuelEconomyForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare variables to hold miles, gallons, and miles per gallon
            double miles, gallons, milesPerGallon;

            if(double.TryParse(milesTextBox.Text, out miles))
            {
                if (double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    milesPerGallon = miles / gallons;
                    mpgLabel.Text = milesPerGallon.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Gallons must be a number");
                }
            }
            else
            {
                MessageBox.Show("Miles must be a number");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}
