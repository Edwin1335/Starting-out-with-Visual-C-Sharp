using System;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class SlotMachineForm : Form
    {
        decimal totalCash;
        int[] choiceArray = new int[3];
        const decimal WIN_AMOUNT = 5.00m;
        const decimal PERC_INCRE = 0.20m;

        public SlotMachineForm()
        {
            InitializeComponent();
        }

        public void SpinSlotMachine()
        {
            Random rand = new Random();
            int index;

            // Random display one
            index = rand.Next(0, 3);
            display1PictureBox.Image = imageList1.Images[index];
            choiceArray[0] = index;

            // Random display one
            index = rand.Next(0, 3);
            display2PictureBox.Image = imageList1.Images[index];
            choiceArray[1] = index;

            // Random display one
            index = rand.Next(0, 3);
            display3PictureBox.Image = imageList1.Images[index];
            choiceArray[2] = index;
        }

        private bool CheckWinner()
        {
            // Check if image tags are the same
            if (choiceArray[0] == choiceArray[1] && choiceArray[1] == choiceArray[2])
            {
                return true;
            }
            return false;
        }

        private void RunWinSimulation()
        {
            decimal moneyWon = WIN_AMOUNT + (PERC_INCRE * totalCash);
            totalCash += moneyWon;
            moneyLabel.Visible = true;
            moneyLabel.Text = moneyWon.ToString("c");
            amountLeftLabel.Text = totalCash.ToString("C");
        }

        private void RunLoseSimulation()
        {
            totalCash = totalCash - 1.00m;
            moneyLabel.Visible = false;

            if(totalCash <= 0)
            {
                totalCash = 0;
                amountLeftLabel.Text = "";

                // Will Display the players amount and reset everything back to the beggining
                MessageBox.Show("Ticke amount : " + totalCash);

                // Hide Buttons
                amountLeftLabel.Enabled = false;
                amountLeftLabel.Visible = false;
                totalPromptLabel.Enabled = false;
                totalPromptLabel.Visible = false;
                SpinButton.Enabled = false;
                SpinButton.Visible = false;
                TicketButton.Visible = false;
                TicketButton.Enabled = false;

                // Retrieve all the cash
                totalCash = 0m;
            }
            else
            {
                amountLeftLabel.Text = totalCash.ToString("C");
            }
        }

        private void SpinButton_Click(object sender, EventArgs e)
        {
            // Spin the slot machine
            this.SpinSlotMachine();

            // Check if player won
            if(CheckWinner())
            {
                RunWinSimulation();
            }
            else
            {
                RunLoseSimulation();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Close the program
            Console.WriteLine(CheckWinner());
            this.Close();
        }

        private void AddMoneyButton_Click(object sender, EventArgs e)
        {
            // Read in the money inserted
            if(decimal.TryParse(insertLabel.Text, out totalCash) && totalCash > 0)
            {
                // Reveal Hidden buttons
                amountLeftLabel.Text = totalCash.ToString("c");
                amountLeftLabel.Enabled = true;
                amountLeftLabel.Visible = true;
                totalPromptLabel.Enabled = true;
                totalPromptLabel.Visible = true;
                SpinButton.Enabled = true;
                SpinButton.Visible = true;
                TicketButton.Visible = true;
                TicketButton.Enabled = true;

                // Remove value from text box
                insertLabel.Text = "";
            }
            else
            {
                insertLabel.Text = "";
                insertLabel.Focus();
                MessageBox.Show("Please add correct amount");
                
            }
        }

        private void TicketButton_Click(object sender, EventArgs e)
        {
            // Will Display the players amount and reset everything back to the beggining
            MessageBox.Show("Ticke amount : " + amountLeftLabel.Text);

            // Hide Buttons
            amountLeftLabel.Enabled = false;
            amountLeftLabel.Visible = false;
            totalPromptLabel.Enabled = false;
            totalPromptLabel.Visible = false;
            SpinButton.Enabled = false;
            SpinButton.Visible = false;
            TicketButton.Visible = false;
            TicketButton.Enabled = false;

            // Retrieve all the cash
            totalCash = 0m;
        }
    }
}
