using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZone
{
    public partial class timeZoneForm : Form
    {
        public timeZoneForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Declare a variable to hold a city name.
            string city;

            if(cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();

                // Determine the city's time zone.
                switch (city)
                {
                    case "Honolulu" :
                        timeZoneLabel.Text = "Hawaii-Aleutian";
                        break;
                    case "San Francisco":
                        timeZoneLabel.Text = "Pacific";
                        break;
                    case "Denver":
                        timeZoneLabel.Text = "Maountain";
                        break;
                    case "Minneapolis":
                        timeZoneLabel.Text = "Central";
                        break;
                    case "New York":
                        timeZoneLabel.Text = "Eastern";
                        break;
                    default:
                        timeZoneLabel.Text = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please select a city first");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
