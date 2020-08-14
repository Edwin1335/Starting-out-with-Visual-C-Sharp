using System;
using System.Windows.Forms;

namespace AccountSumilatorClass
{
    public partial class BankAccountForm : Form
    {
        const decimal STARTING_BALANCE = 1000.00m;
        BankAccount myAccount;
        public BankAccountForm()
        {
            InitializeComponent();
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
            string input = depositLabel.Text;
            decimal amount;

            if(input != "" && decimal.TryParse(input, out amount))
            {
                myAccount.MakeADeposit(amount);
                balanceLabel.Text = myAccount.GetAmount().ToString();
            }
            else
            {
                depositLabel.Text = "";
                depositLabel.Focus();
                MessageBox.Show("Please enter correct amount");
            }
            depositLabel.Text = "";

        }

        private void withdrawlButton_Click(object sender, EventArgs e)
        {
            string input = withdrawlLabel.Text;
            decimal amount;

            if (input != "" && decimal.TryParse(input, out amount))
            {
                myAccount.MakeAWithdrawl(amount);
                balanceLabel.Text = myAccount.GetAmount().ToString();
            }
            else
            {
                withdrawlLabel.Focus();
                MessageBox.Show("Please enter correct amount");
            }
            withdrawlLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BankAccountForm_Load(object sender, EventArgs e)
        {
            balanceLabel.Text = STARTING_BALANCE.ToString();
            myAccount = new BankAccount(STARTING_BALANCE);
        }
    }
}
