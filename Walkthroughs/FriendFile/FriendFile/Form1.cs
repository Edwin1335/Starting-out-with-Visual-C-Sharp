using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FriendFile
{
    public partial class friendForm : Form
    {
        public friendForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text != "")
                {
                    StreamWriter output;
                    output = File.AppendText("Friend.txt");
                    output.WriteLine(nameTextBox.Text);
                    output.Close();
                    nameTextBox.Text = "";
                    nameTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter a name");
                }
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
