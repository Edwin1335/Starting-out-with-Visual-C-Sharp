using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndingBalance
{
    public partial class balanceForm : Form
    {
        public balanceForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal balance;
            int months;
            string outputString;
            const decimal INTEREST_RATE = 0.005m;

            if(decimal.TryParse(balanceTextBox.Text, out balance))
            {
                if(int.TryParse(monthsTextBox.Text, out months))
                {
                    if(months > 0 && months <= 12)
                    {
                        int counter = 1;
                        while(counter <= months)
                        {
                            balance = balance + (INTEREST_RATE * balance);
                            outputString = "The ending balance for month " + counter + " is " + balance.ToString("c");
                            detailListBox.Items.Add(outputString);
                            counter++;
                        }

                        balanceLabel.Text = balance.ToString("c");
                    }
                    else
                    {
                        MessageBox.Show("Months must be between 1 and 12");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter correct number of Months");
                }
            }
            else
            {
                MessageBox.Show("Please enter correct Starting Balance");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clearing all values
            balanceLabel.Text = "";
            balanceTextBox.Text = "";
            monthsTextBox.Text = "";

            detailListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
