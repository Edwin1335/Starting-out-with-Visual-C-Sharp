using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordValidation
{
    public partial class passwordLabel : Form
    {
        public passwordLabel()
        {
            InitializeComponent();
        }

        private bool ValidatePassword(ref string pass)
        {
            bool passNumber = false;
            bool passUpper = false;
            bool passLower = false;

            // Check validation for "Must include at least one number"
            foreach(char c in pass)
            {
                if (char.IsDigit(c))
                {
                    passNumber = true;
                    break;
                }
            }

            // Check validation for "Must include at least one lowercase letter"
            foreach (char c in pass)
            {
                if (char.IsLower(c))
                {
                    passLower = true;
                    break;
                }
            }

            // Check validation for "Must include at least one uppercase letter"
            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                {
                    passUpper = true;
                    break;
                }
            }

            // Check final logical validations
            if (pass == "")
            {
                MessageBox.Show("Password cannot be empty");
                return false;
            }
            if(pass.Length < 8)
            {
                MessageBox.Show("Password myst be at least 8 characters long");
                return false;
            }
            if (!passUpper)
            {
                MessageBox.Show("Password must contain an upper case letter");
                return false;
            }
            else if(!passLower)
            {
                MessageBox.Show("Password must contain an lower case letter");
                return false;
            }
            else if (!passNumber)
            {
                MessageBox.Show("Password must contain a number");
                return false;
            }
            else
            {
                return true;
            }

            return false;
        }

        private void PasswordButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;

            // Check password validation
            try
            {
                if(ValidatePassword(ref password))
                {
                    MessageBox.Show("CORRECT PASSWORD !!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit the program
            this.Close();
        }
    }
}
