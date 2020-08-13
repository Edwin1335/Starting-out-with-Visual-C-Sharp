using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TestAverageDelimeter
{
    public partial class testAverageForm : Form
    {
        private string fileName;

        public testAverageForm()
        {
            InitializeComponent();
        }

        private void GetFileName(ref string fileName)
        {
            // Open File Dialog Box and pick a file to read
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
            else
            {
                fileName = "";
            }
        }

        private void DisplayScores(ref string fileName)
        {
            // Read from the file.
            StreamReader inputFile;
            string fileLine;

            try
            {
                inputFile = File.OpenText(fileName);
                while (!inputFile.EndOfStream)
                {
                    fileLine = inputFile.ReadLine();
                    scoresListBox.Items.Add(fileLine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayAverage(ref string fileName)
        {
            StreamReader inputFile;
            char delimeter = ',';
            string fileLine;
            double total, average;
            int countStudents = 1;
            try
            {
                inputFile = File.OpenText(fileName);
                while (!inputFile.EndOfStream)
                {
                    fileLine = inputFile.ReadLine();
                    fileLine = fileLine.Trim();

                    average = 0;
                    total = 0;
                    string[] scores = fileLine.Split(delimeter);

                    foreach (string sc in scores)
                    {
                        // Get total
                        total += double.Parse(sc);
                    }

                    // Get average
                    average = total / scores.Length;

                    // Diplay in average list box 
                    averagesListBox.Items.Add("Average for student " + countStudents +
                        " is " +average.ToString("N1"));
                    countStudents++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void GetScoresButton_Click(object sender, EventArgs e)
        {
            this.GetFileName(ref this.fileName);
            this.DisplayScores(ref this.fileName);
        }

        private void GetAveragerButton_Click(object sender, EventArgs e)
        {
            this.DisplayAverage(ref fileName);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
