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
                timePeriod = double.Parse(yearsTextBox.Text);
                interestRate = double.Parse(interestTextBox.Text) /100;

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
                    MessageBox.Show("Must select times per year that interest will be compounded.");
                }
                
                double total = CompoundCalculator.CalculateTotalWithCompoundInterest(principal, interestRate, compoundingFrequency, timePeriod, monthlyAdditions);
                outputLabel.Text = total.ToString();


               outputLabel.Text = "Your balance after" + " " + yearsTextBox.Text + " " + "years" + " " + "is" + " " + total.ToString("C");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Use Alphabetical Characters, Please Use Numbers Instead");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            principalTextBox.Text = " ";
            contributeTextBox.Text = " ";
            yearsTextBox.Text = " ";
            interestTextBox.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
