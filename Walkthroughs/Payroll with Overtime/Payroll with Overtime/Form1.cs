using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class payrollForm : Form
    {
        public payrollForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal BASE_HOURS = 40m;
            const decimal OT_MULTIPLIER = 1.5m;

            try
            {
                decimal hoursWorked, hourlyPayRate, basePay;
                decimal overtimeHours, overtimePay, grossPay;

                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyRateTextBox.Text);

                // Check if user did overtime
                if(hoursWorked > BASE_HOURS)
                {
                    // Get overtime pay and base pay 
                    basePay = hourlyPayRate * BASE_HOURS;
                    overtimeHours = hoursWorked - BASE_HOURS;
                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;

                    // Get gross pay
                    grossPay = overtimePay + basePay;
                }
                else
                {
                    grossPay = hourlyPayRate * hoursWorked;
                }

                // Display the gross pay
                grossPayLabel.Text = grossPay.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the text in the text boxes
            grossPayLabel.Text = "";
            hoursWorkedTextBox.Text = "";
            hourlyRateTextBox.Text = "";

            // Refocus 
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
