using System;
using System.IO;
using System.Windows.Forms;

namespace LoadEvent
{
    public partial class southAmericaForm : Form
    {
        public southAmericaForm()
        {
            InitializeComponent();
        }

        private void southAmericaForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Declare a variable to hold a country name
                string countryName;

                // Declare a StreamREader variable
                StreamReader inputFile;

                // Open a file and get a streameReader object 
                inputFile = File.OpenText("Countries.txt");

                // Read the file's contents
                while (!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }

                // Close the file
                inputFile.Close();
            }
            catch (Exception ex)
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
