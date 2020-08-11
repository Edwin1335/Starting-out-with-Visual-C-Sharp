using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalePriceCalculator
{
    public partial class salesPriceCalculatorForm : Form
    {
        public salesPriceCalculatorForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Declare varaibales to hold specific vlaues
            double percentage, originalPrice, salesPrice, discount;

            // Get values from input
            originalPrice = double.Parse(originalPriceTextBox.Text);
            salesPrice = originalPrice;
            percentage = double.Parse(discountPercentageTextBox.Text) / 100;

            // Perform the MF arithmatic operations
            discount = originalPrice * percentage;
            salesPrice -= discount;

            salePriceLabel.Text = salesPrice.ToString("c");
        }
    }
}
