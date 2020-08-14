using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace E_MailAddressBook
{
    public partial class RosterForm : Form
    {
        private List<PersonEntry> Roster;

        public RosterForm()
        {
            InitializeComponent();
        }

        private void GetFileName(ref string fileName)
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

        private void GetNamesButton_Click(object sender, EventArgs e)
        {
            StreamReader inpuFile;
            string fileLine = "";

            // Get the file name
            string fileName = "";
            GetFileName(ref fileName);

            try
            {
                inpuFile = File.OpenText(fileName);
                while(!inpuFile.EndOfStream)
                {
                    // Get the individual info and trim the ends for whitespace
                    fileLine = inpuFile.ReadLine();
                    fileLine = fileLine.TrimEnd();
                    fileLine = fileLine.TrimStart();

                    // Print value for testing 
                    Console.WriteLine(fileLine);

                    // Get individaul componenets
                    string[] token = fileLine.Split('\t');

                    // Print the name into list box
                    nameListBox.Items.Add(token[0]);

                    // Add new obect person to roster list
                    PersonEntry newEntry = new PersonEntry(token[0], token[1], token[2], token[3]);
                    Roster.Add(newEntry);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RosterForm_Load(object sender, EventArgs e)
        {
            // Initiate a list of person entries
            Roster = new List<PersonEntry>();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (nameListBox.SelectedIndex != -1)
            {
                // Get the index of Roster list and list box
                int index = nameListBox.SelectedIndex;

                // Create and isntance of the form with the following stuff
                DisplayForm displayForm = new DisplayForm();
                displayForm.nameLabel.Text = Roster[index].Name;
                displayForm.lastNameLabel.Text = Roster[index].lastName;
                displayForm.emailLabel.Text = Roster[index].Email;
                displayForm.numberLabel.Text = Roster[index].phoneNumber;

                // Display the form with the infomation
                displayForm.ShowDialog();
            }
        }
    }
}
