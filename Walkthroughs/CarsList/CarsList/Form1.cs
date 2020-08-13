using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsList
{
    struct Car
    {
        public string name;
        public int year;
        public double miealage;
    }

    public partial class carListForm : Form
    {
        private List<Car> carList = new List<Car>();

        public carListForm()
        {
            InitializeComponent();
        }

        private bool GetCarInfo(ref string make, ref int year, ref double mileage)
        {
            if(mileTextBox.Text == "" || yearTexBox.Text == "" || mileageTextBox.Text == "")
            {
                MessageBox.Show("Please enter values for make year and mileage");
                return false;
            }
            else
            {
                make = mileTextBox.Text;

                if(!int.TryParse(yearTexBox.Text, out year) && year > 0 && year < 2050)
                {
                    MessageBox.Show("Year must be an integer");
                    return false;
                }
                if(!double.TryParse(mileageTextBox.Text, out mileage) && mileage > 0)
                {
                    MessageBox.Show("Year must be an double");
                    return false;
                }
            }
            return true;
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            string make = "";
            int year = -1;
            double mileage = -1;
            
            // Insert new car into list 
            if(GetCarInfo(ref make,ref year,ref mileage))
            {
                Car newCar;
                newCar.name = make;
                newCar.year = year;
                newCar.miealage = mileage;

                carList.Add(newCar);

                // Clear all the values
                mileTextBox.Text = "";
                mileageTextBox.Text = "";
                yearTexBox.Text = "";

                // Refocus
                mileTextBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Car c in carList)
            {
                carListBox1.Items.Add(c.name + " " + c.year + ", " + c.year);
            }
        }
    }
}
