using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSelector
{
    public partial class worskopForm : Form
    {
        public worskopForm()
        {
            InitializeComponent();
        }

        private void calcualteButton_Click(object sender, EventArgs e)
        {
            // Variables to hold the following values;
            decimal totalFee = 0, registrationFee = 0, lodgingFee = 0;
            int days = 0;

            if(registrationFeesListBox.SelectedIndex != -1 && lodgingFeesListBox.SelectedIndex != -1)
            {
                // Check registration fee
                if(registrationFeesListBox.SelectedIndex == 0)
                {
                    days = 3;
                    registrationFee = 1000m;
                }
                else if (registrationFeesListBox.SelectedIndex == 1)
                {
                    days = 3;
                    registrationFee = 800m;
                }
                else if (registrationFeesListBox.SelectedIndex == 2)
                {
                    days = 3;
                    registrationFee = 1500m;
                }
                else if (registrationFeesListBox.SelectedIndex == 3)
                {
                    days = 5;
                    registrationFee = 1300m;
                }
                else if (registrationFeesListBox.SelectedIndex == 4)
                {
                    days = 1;
                    registrationFee = 500m;
                }
                else
                {
                    MessageBox.Show("Miscalculated Error");
                }

                // Check lodging fee
                if(lodgingFeesListBox.SelectedIndex == 0)
                {
                    lodgingFee = 150m;
                }
                else if(lodgingFeesListBox.SelectedIndex == 1)
                {
                    lodgingFee = 225m;
                }
                else if (lodgingFeesListBox.SelectedIndex == 2)
                {
                    lodgingFee = 175m;
                }
                else if (lodgingFeesListBox.SelectedIndex == 3)
                {
                    lodgingFee = 300m;
                }
                else if (lodgingFeesListBox.SelectedIndex == 4)
                {
                    lodgingFee = 175m;
                }
                else if (lodgingFeesListBox.SelectedIndex == 5)
                {
                    lodgingFee = 150m;
                }
                else
                {
                    MessageBox.Show("Miscalculated Error");
                }

                totalFee = registrationFee + (lodgingFee * days);

                totalAnswerLabel.Text = totalFee.ToString("C");
            }
            else
            {
                MessageBox.Show("Please select a lodging and registration fee");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes the program
            this.Close();
        }
    }
}
