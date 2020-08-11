using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class stadiumSeatingForm : Form
    {
        // Creating constant private datatypes
        private const int classACost = 15;
        private const int classBCost = 12;
        private const int classCCost = 9;

        public stadiumSeatingForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare placeholder variables
                int total, classASales, classBSales, classCSales;

                // Initialize variables
                classASales = int.Parse(classATextBox.Text);
                classBSales = int.Parse(classBTextBox.Text);
                classCSales = int.Parse(classCTextBox.Text);

                // Calculate labes and total
                classARevenueLabel.Text = (classASales * classACost).ToString("C");
                classBRevenueLabel.Text = (classBSales * classBCost).ToString("C");
                classCRevenueLabel.Text = (classCSales * classCCost).ToString("C");
                total = (classASales * classACost) + (classBSales * classBCost) + 
                    (classCSales * classCCost);

                totalAnswerLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clearing all data
            classARevenueLabel.Text = "";
            classBRevenueLabel.Text = "";
            classCRevenueLabel.Text = "";
            totalAnswerLabel.Text = "";

            // Refocus
            classATextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
