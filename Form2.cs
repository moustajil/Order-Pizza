using System;
using System.Windows.Forms;

namespace Order_Pizza
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Calculate total based on size and toppings
        private void UpdateTotal()
        {
            int total = 0;

            // Size
            if (rdSmall.Checked)
            {
                total += Convert.ToInt32(rdSmall.Tag);
                lbSize.Text = "Small";
            }
            else if (rdMedium.Checked)
            {
                total += Convert.ToInt32(rdMedium.Tag);
                lbSize.Text = "Medium";
            }
            else if (rdLarge.Checked)
            {
                total += Convert.ToInt32(rdLarge.Tag);
                lbSize.Text = "Large";
            }

            // Toppings
            lbTopping.Text = ""; // clear previous
            if (chExtraChesse.Checked)
            {
                total += Convert.ToInt32(chExtraChesse.Tag);
                lbTopping.Text += "Extra Cheese, ";
            }
            if (chGreenPapers.Checked)
            {
                total += Convert.ToInt32(chGreenPapers.Tag);
                lbTopping.Text += "Green Peppers, ";
            }
            if (chMashrume.Checked)
            {
                total += Convert.ToInt32(chMashrume.Tag);
                lbTopping.Text += "Mushroom, ";
            }
            if (chOlivies.Checked)
            {
                total += Convert.ToInt32(chOlivies.Tag);
                lbTopping.Text += "Olives, ";
            }
            if (chOnion.Checked)
            {
                total += Convert.ToInt32(chOnion.Tag);
                lbTopping.Text += "Onion, ";
            }
            if (chTomato.Checked)
            {
                total += Convert.ToInt32(chTomato.Tag);
                lbTopping.Text += "Tomato, ";
            }

            // Remove trailing comma if any
            lbTopping.Text = lbTopping.Text.TrimEnd(',', ' ');

            // Crust
            if (rdThinCrust.Checked)
            {
                total += Convert.ToInt32(rdThinCrust.Tag);
                lbCrustType.Text = "Thin Crust";
            }
            if (rdThinkCrust.Checked)
            {
                total += Convert.ToInt32(rdThinkCrust.Tag);
                lbCrustType.Text = "Thick Crust";
            }

            // Where You Eat It
            if (rdEatIn.Checked)
            {
                lbWher.Text = "Eat In";
            }
            else if (rdEatOut.Checked)
            {
                lbWher.Text = "Eat Out";
            }

            // Update the total label
            lbTotal.Text = total.ToString();
        }

        // Size RadioButtons event
        private void rdSmall_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void rdMedium_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void rdLarge_CheckedChanged(object sender, EventArgs e) => UpdateTotal();

        // Toppings CheckBoxes event
        private void chExtraChesse_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void chGreenPapers_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void chMashrume_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void chTomato_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void chOnion_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void chOlivies_CheckedChanged(object sender, EventArgs e) => UpdateTotal();

        

        // Eat Option
        private void rdEatIn_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void rdEatOut_CheckedChanged(object sender, EventArgs e) => UpdateTotal();


        // Crust RadioButtons
        private void rdThinCrust_CheckedChanged(object sender, EventArgs e) => UpdateTotal();
        private void rdThinkCrust_CheckedChanged(object sender, EventArgs e) => UpdateTotal();


        // Confrim Order
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Confrime Order ", "Confrim", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                grCustSize.Enabled = false;
                grEat.Enabled = false;
                grSize.Enabled = false;
                grTopping.Enabled = false;
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            grCustSize.Enabled = true;
            grEat.Enabled = true;
            grSize.Enabled = true;
            grTopping.Enabled = true;
        }
    }
}
