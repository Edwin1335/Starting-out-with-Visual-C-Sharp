using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latin_Translator
{
    public partial class latinTranslatorForm : Form
    {
        public latinTranslatorForm()
        {
            InitializeComponent();
        }

        private void sinisterButton_Click(object sender, EventArgs e)
        {
            englishAnwer.Visible = true;
            englishAnwer.Text = "Left";
        }

        private void dexterButton_Click(object sender, EventArgs e)
        {
            englishAnwer.Visible = true;
            englishAnwer.Text = "Right";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            englishAnwer.Visible = true;
            englishAnwer.Text = "Center";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
