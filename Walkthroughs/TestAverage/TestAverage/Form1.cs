using System;
using System.IO;
using System.Windows.Forms;

namespace TestAverage
{
    public partial class averageFrom : Form
    {
        public averageFrom()
        {
            InitializeComponent();
        }

        private void GetFileName(out string fileName)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
            else
            {
                fileName = "";
            }
        }

        private void GetScoresFromFile(double[] scores, string fileName)
        {
            int counter = 0;
            StreamReader inputFile;
            inputFile = File.OpenText(fileName);

            // Get scores from file
            while(counter < scores.Length && (!inputFile.EndOfStream))
            {
                scores[counter] = double.Parse(inputFile.ReadLine());
                counter++;
            }

            // Display scores on list box
            foreach(double var in scores)
            {
                testScoreListBox.Items.Add(var);
            }
        }

        private void CalculateScores(double[] scores)
        {
            double highest, average, lowest, total;
            highest = scores[0];
            average = scores[0];
            lowest = scores[0];
            total = 0;

            for(int i =0; i < scores.Length; i++)
            {
                if(highest < scores[i])
                {
                    highest = scores[i];
                }
                if(lowest > scores[i])
                {
                    lowest = scores[i];
                }

                total += scores[i];
            }

            average = total / scores.Length;

            // Display values in the corresponding labels
            averageScoreLabel.Text = average.ToString();
            lowestScoreLabel.Text = lowest.ToString();
            highestScoreLabel.Text = highest.ToString();

        }

        private void DisplayScores(ref string fileName)
        {
            StreamReader inputFile;
            inputFile = File.OpenText(fileName);
        }

        private void getScoreButton_Click(object sender, EventArgs e)
        {
            string fileName;
            double[] scores = new double[5];

            // Get the file name from the user
            GetFileName(out fileName);

            // Check if file name is saved
            if(fileName != "")
            {
                // Get scores from file and display them on the list box
                GetScoresFromFile(scores, fileName);
                // Display calculated scores
                CalculateScores(scores);
            }
            else
            {
                MessageBox.Show("File not chosen");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
