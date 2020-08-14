using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSumilatorClass
{
    class BankAccount
    {
        private decimal totalAmount;

        public BankAccount()
        {
            totalAmount = 0m;
        }

        public BankAccount(decimal totalAmount)
        {
            this.totalAmount = totalAmount;
        }

        public decimal GetAmount()
        {
            return this.totalAmount;
        }

        public void MakeADeposit(decimal amount)
        {
            if (amount >= 0)
            {
                this.totalAmount += amount;
            }
            else
            {
                MessageBox.Show("Cannot deposit negative money");
            }
        }

        public void MakeAWithdrawl(decimal amount)
        {
            if((totalAmount - amount) >= 0)
            {
                totalAmount -= amount;
            }
            else
            {
                MessageBox.Show("Not enough money to widthdraw");
            }
        }
    }
}
