using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_sAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double OilAndLubePrice()
        {
            double total = 0;
            if(oilChangeCheckBox.Checked == true)
            {
                total += 26.00;
            }
            if(lubeJobCheckBox.Checked == true)
            {
                total += 18.00;
            }
            return total;
        }

        private double FlushesPrice()
        {
            double total = 0;
            if (radiationFlushCheckBox.Checked == true)
            {
                total += 30.00;
            }
            if (transmissionFlushCheckBox.Checked == true)
            {
                total += 80.00;
            }
            return total;
        }

        private double MiscPrice()
        {
            double total = 0;
            if (inspectionCheckBox.Checked == true)
            {
                total += 15.00;
            }
            if (replaceMufflerCheckBox.Checked == true)
            {
                total += 100.00;
            }
            if (tireRotationCheckBox.Checked == true)
            {
                total += 20.00;
            }
            return total;
        }

        private double GetParts()
        {
            int parts = 0;

            if(int.TryParse(partsTextBox.Text, out parts))
            {
                
            }
            else
            {
                MessageBox.Show("Please provide the correct number of parts");
            }

            return parts;
        }

        private double HoursWorked()
        {
            int totalHours = 0;
            if (int.TryParse(partsTextBox.Text, out totalHours))
            {

            }
            else
            {
                MessageBox.Show("Please provide the correct number of parts");
            }

            return totalHours;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double COST_PER_HOUR = 20.00;
            const double TAX = .08;
            double service, tx;

            // Get servies and labor
            service = OilAndLubePrice() + MiscPrice() + FlushesPrice();
            serviceLabel.Text = service.ToString();
           
            // Get number of parts 
            partsLabel.Text = GetParts().ToString();

            // Display Taxes
            taxLabel.Text = (GetParts() * TAX).ToString();

            // Total Fees
            totalLabel.Text = (service + (GetParts() * TAX) + (HoursWorked() * COST_PER_HOUR)).ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control gb in this.Controls)
            {
                if (gb is GroupBox)
                {
                    foreach (Control tb in gb.Controls)
                    {
                        if (tb is TextBox)
                        {
                            tb.Controls.Clear();
                        }
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
