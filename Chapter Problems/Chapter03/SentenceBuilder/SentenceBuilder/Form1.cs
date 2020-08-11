using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentenceBuilder
{
    public partial class sentenceBuilderForm : Form
    {
        // Sentence varaiable;
        private string sentence = "";
        public sentenceBuilderForm()
        {
            InitializeComponent();
        }

        private void capAButton_Click(object sender, EventArgs e)
        {
            sentence += "A";
            sentenceLabel.Text = sentence;
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            sentence += "a";
            sentenceLabel.Text = sentence;
        }

        private void anButton_Click(object sender, EventArgs e)
        {
            sentence += "an";
            sentenceLabel.Text = sentence;
        }

        private void capAnButton_Click(object sender, EventArgs e)
        {
            sentence += "An";
            sentenceLabel.Text = sentence;
        }

        private void capTheButton_Click(object sender, EventArgs e)
        {
            sentence += "The";
            sentenceLabel.Text = sentence;
        }

        private void theButton_Click(object sender, EventArgs e)
        {
            sentence += "the";
            sentenceLabel.Text = sentence;
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            sentence += "man";
            sentenceLabel.Text = sentence;
        }

        private void womenButton_Click(object sender, EventArgs e)
        {
            sentence += "women";
            sentenceLabel.Text = sentence;
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            sentence += "cat";
            sentenceLabel.Text = sentence;
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            sentence += "car";
            sentenceLabel.Text = sentence;
        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            sentence += "bicycle";
            sentenceLabel.Text = sentence;
        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            sentence += "dog";
            sentenceLabel.Text = sentence;
        }

        private void beautifulButton_Click(object sender, EventArgs e)
        {
            sentence += "beautiful";
            sentenceLabel.Text = sentence;
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            sentence += "big";
            sentenceLabel.Text = sentence;
        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            sentence += "small";
            sentenceLabel.Text = sentence;
        }

        private void strangeButton_Click(object sender, EventArgs e)
        {
            sentence += "strange";
            sentenceLabel.Text = sentence;
        }

        private void lookedAtButton_Click(object sender, EventArgs e)
        {
            sentence += "looked";
            sentenceLabel.Text = sentence;
        }

        private void roderButton_Click(object sender, EventArgs e)
        {
            sentence += "rode";
            sentenceLabel.Text = sentence;
        }

        private void spokedToButton_Click(object sender, EventArgs e)
        {
            sentence += "spooked";
            sentenceLabel.Text = sentence;
        }

        private void laughedAtButton_Click(object sender, EventArgs e)
        {
            sentence += "laughed";
            sentenceLabel.Text = sentence;
        }

        private void droveButton_Click(object sender, EventArgs e)
        {
            sentence += "drove";
            sentenceLabel.Text = sentence;
        }

        private void spaceButton_Click(object sender, EventArgs e)
        {
            sentence += " ";
            sentenceLabel.Text = sentence;
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            sentence += ".";
            sentenceLabel.Text = sentence;
        }

        private void exclamationButton_Click(object sender, EventArgs e)
        {
            sentence += "!";
            sentenceLabel.Text = sentence;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sentence = "";
            sentenceLabel.Text = sentence;

            capAButton.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
