using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class catsForm : Form
    {
        public catsForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void batmanPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Its Batman!");
        }

        private void catPictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture of cat sitting");
        }

        private void memePictureBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funny Meme");
        }
    }
}
