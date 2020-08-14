using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachineSimulator
{
    struct Drinks
    {
        public string name;
        public decimal cost;
        public int items;
    }

    public partial class VendingMachineForm : Form
    {
        Drinks[] drinks = new Drinks[5];
        const int totalItems = 20;
        decimal totalCost = 0;

        public VendingMachineForm()
        {
            InitializeComponent();
        }

        private void VendingMachineForm_Load(object sender, EventArgs e)
        {
            colaItemsLabel.Text = totalItems.ToString();
            fantaItemsLabel.Text = totalItems.ToString();
            waterItemsLabel.Text = totalItems.ToString();
            rootItemsLabel.Text = totalItems.ToString(); 
            spriteItemsLabel.Text = totalItems.ToString();
            totalLabel.Text = totalCost.ToString("c");

            // Declare the name of drinks
            drinks[0].name = "Coca Cola";
            drinks[1].name = "Fanta";
            drinks[2].name = "Root Beer";
            drinks[3].name = "Sprite";
            drinks[4].name = "Water";

            // Declare prices for drinks
            for(int i =0; i < (drinks.Length - 1); i++)
            {
                drinks[i].items = totalItems;
                drinks[i].cost = 1m;
            }

            drinks[4].cost = .95m;
            drinks[4].items = totalItems;
        }

        private void UpdateTotal(decimal cost)
        {
            totalCost += cost;
            totalLabel.Text = totalCost.ToString();
        }

        private void CocaColaGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateTotal(drinks[0].cost);
        }

        private void FantaGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateTotal(drinks[1].cost);
        }

        private void RootGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateTotal(drinks[2].cost);
        }

        private void SpriteGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateTotal(drinks[3].cost);
        }

        private void WaterGroupBox_Enter(object sender, EventArgs e)
        {
            UpdateTotal(drinks[4].cost);
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Total is: " + totalCost.ToString());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the program 
            this.Close();
        }
    }
}
