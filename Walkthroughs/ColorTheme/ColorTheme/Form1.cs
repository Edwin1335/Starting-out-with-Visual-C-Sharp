using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTheme
{
    public partial class colorThemeForm : Form
    {
        public colorThemeForm()
        {
            InitializeComponent();
        }

        private void geenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (geenRadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yellowRadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void grayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (grayRadioButton.Checked)
            {
                this.BackColor = Color.Gray;
            }
        }

        private void redradioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (redradioButton.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void blueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (blueRadioButton.Checked)
            {
                this.BackColor = Color.LightBlue;
            }
        }
    }
}
