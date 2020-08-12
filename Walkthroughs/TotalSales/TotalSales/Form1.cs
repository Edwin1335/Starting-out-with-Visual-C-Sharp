using System;
using System.IO;
using System.Windows.Forms;

namespace TotalSales
{
    public partial class salesForm : Form
    {
        public salesForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Sales.txt");
                decimal total = 0;
                while (!inputFile.EndOfStream)
                {
                    total += Decimal.Parse(inputFile.ReadLine());
                }

                totalSalesLabel.Text = total.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
