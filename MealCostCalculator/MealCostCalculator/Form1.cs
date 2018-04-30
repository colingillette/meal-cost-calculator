using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealCostCalculator
{
    public partial class Form1 : Form
    {
        const double TAX_RATE = 0.076;
        const double EXTRA_DISCOUNT = 0.1;
        double mealCost, tax, tipRate, totalCost, tip;

        private void tipItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            caclulateButton.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void caclulateButton_Click(object sender, EventArgs e)
        {
            //Validate Meal Cost
            if (!Double.TryParse(mealCostTextBox.Text, out mealCost))
            {
                mealCostTextBox.Clear();
                mealCostTextBox.Focus();
                MessageBox.Show("Please input valid numbers only.");
            }
            else
            {
                Double.TryParse(mealCostTextBox.Text, out mealCost);

                //Check for extra discounts
                if (veteranCheckBox.Checked || seniorCheckBox.Checked || studentCheckBox.Checked)
                {
                    mealCost = mealCost - (mealCost * EXTRA_DISCOUNT);
                }

                tax = mealCost * TAX_RATE;

                //Set tipRate
                switch (tipItemsListBox.Text)
                {
                    case "10%":
                        tipRate = .1;
                        break;
                    case "15%":
                        tipRate = .15;
                        break;
                    case "20%":
                        tipRate = .2;
                        break;
                    case "25%":
                        tipRate = .25;
                        break;
                    case "30%":
                        tipRate = .3;
                        break;
                    case "35%":
                        tipRate = .35;
                        break;
                    default:
                        tipRate = 0;
                        break;
                }

                //Calculate the Total and tip.
                //Include tax in tip calculation like you typically would for a check.
                tip = tipRate * (mealCost + tax);
                totalCost = tip + mealCost + tax;

                //Display totalCost
                MessageBox.Show($"Your total cost is: {totalCost.ToString("c")}");
            }
        }

        private void lesserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipItemsListBox.Items.Clear();
            tipItemsListBox.Items.Add("None");

            for (int i = 10; i <= 35; i += 5)
            {
                tipItemsListBox.Items.Add($"{i}%");
            }
        }

        private void greaterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            tipItemsListBox.Items.Clear();

            for (int i = 15; i <= 35; i += 5)
            {
                tipItemsListBox.Items.Add($"{i}%");
            }
        } 
    }
}
