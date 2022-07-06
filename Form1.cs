using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class fatPercentage : Form
    {
        public fatPercentage()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // String different amounts that need to be found
            decimal fat;
            decimal calories;
            decimal fromfat;
            decimal percentage;
            decimal lowfatpercent;

            // Alert user if it isn't the right character

           
            lowfatpercent = decimal.Parse("0.3");

            if (decimal.TryParse(caloriesTxt.Text, out calories))
            {
                if (decimal.TryParse(fatTxt.Text, out fat))
                {
                    // fat equation
                    fromfat = fat * 9;
                    percentage = fromfat / calories;

                    // make it appear

                    fatRLbl.Text = fromfat.ToString();

                    percentageRLbl.Text = percentage.ToString("P");

                    if (lowfatCheckBox.Checked)
                    {
                        if (percentage < lowfatpercent)
                        {
                            label1.Text = "This food item is low fat";
                        }

                        else
                        {
                            label1.Text = "This item is not low fat";
                        }
                    }
                }

                else
                {
                    //Display error message
                    MessageBox.Show("Invalid Input. Please enter valid number");
                }

                
            }

            else
            {
                //Display error message
                MessageBox.Show("Invalid Input. Please enter valid number");
            }

            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fatRLbl.Text = "";
            percentageRLbl.Text = "";
            caloriesTxt.Text = "";
            fatTxt.Text = "";
            label1.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
           
