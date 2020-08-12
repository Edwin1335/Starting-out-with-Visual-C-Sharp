using System;
using System.IO;
using System.Windows.Forms;

namespace RandomNumberFileReader
{
    public partial class randomForm : Form
    {
        // Open file 
        StreamWriter outFile;
        StreamReader inFile;

        public randomForm()
        {
            InitializeComponent();
        }

        private void runNumbersButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables declaration
                int counter;

                // Create rabdom object 
                Random rand = new Random();

                if(int.TryParse(numberTextBox.Text, out counter))
                {
                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        outFile = File.AppendText(saveFileDialog.FileName);
                        
                        for(int i = 0; i < counter; i++)
                        {
                            outFile.WriteLine(rand.Next(1, 100));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error please eneter correct amount of random numbers");
                }
                outFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void getNumbersButton_Click(object sender, EventArgs e)
        {
            try
            {

                    inFile = File.OpenText(saveFileDialog.FileName);
                    while(!inFile.EndOfStream)
                    {
                        numbersListBox.Items.Add(inFile.ReadLine());
                    }
                inFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the program
            this.Close();
        }
    }
}
