using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Decalare Variables
                double principal;
                double monthlyAdditions;
                double timePeriod;
                double interestRate;
                double compoundingFrequency = 0;
           


                // Get input values from the textbox and initialize values
                principal = double.Parse(principalTextBox.Text);
                monthlyAdditions = double.Parse(contributeTextBox.Text);
                timePeriod = Int32.Parse(yearsTextBox.Text);
                interestRate = double.Parse(interestTextBox.Text) /100;

                // If - else statements for initializing compundFrequency variable
                if (compoundComboBox.Text == "Monthly")
                {
                    compoundingFrequency = 12;
                }
                else if (compoundComboBox.Text == "Quarterly")
                {
                    compoundingFrequency = 4;
                }
                else if (compoundComboBox.Text == "Semiannually")
                {
                    compoundingFrequency = 2;
                }
                else if (compoundComboBox.Text == "Annually")
                {
                    compoundingFrequency = 1; 
                }
                else
                    
                {
                    // Error message when no compund intrest has been selected.
                    MessageBox.Show("Must select times per year that interest will be compounded.");
                }

                //Calling the CalculateTotalWithCompoundInterest function to retirieve the compound intrest future value.
                double total = CompoundCalculator.CalculateTotalWithCompoundInterest(principal, interestRate, compoundingFrequency, timePeriod, monthlyAdditions);
                outputLabel.Text = total.ToString();

               //Display the results to the user in the form. 
               outputLabel.Text = "The future value in " + " " + yearsTextBox.Text + " " + "years" + " " + "is" + " " + total.ToString("C");

            }
            catch 
            {
                //Error message displayed 
                MessageBox.Show("Alphabetical characters NOT allowed, Please Use Numbers Instead");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear the text boxes
            principalTextBox.Text = " ";
            contributeTextBox.Text = " ";
            yearsTextBox.Text = " ";
            interestTextBox.Text = " ";
            outputLabel.Text = " ";
            compoundComboBox.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formulaReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Reference for how to calculate compound intrest
            System.Diagnostics.Process.Start("https://www.wikihow.com/Calculate-Compound-Interest");

        }
    }
}
