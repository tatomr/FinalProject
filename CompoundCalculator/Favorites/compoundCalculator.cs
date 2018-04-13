using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void inputLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // declaring all variables
                double Principal, Additions, FutureValue, annualContrib;
                double InterestRate;
                int YearsToGrow, CompoundType;

                // Parsing text to digits
                Principal = Double.Parse(inPrincipalTB.Text);
                InterestRate = Double.Parse(inInterestRateTB.Text) / 100;
                Additions = Double.Parse(inAdditionsTB.Text);
                YearsToGrow = Int32.Parse(inYearsGrowthTB.Text);
				
                // establishing Compounding Frequencies
                if (monthlyRB.Checked)
                    CompoundType = 12;
                else if (quarterlyRB.Checked)
                    CompoundType = 4;
                else if (semiannuallyRB.Checked)
                    CompoundType = 2;
                else
                    CompoundType = 1;

                //establishing i in the Future Value formula
                double i = InterestRate / CompoundType;
                //establishing other variables in Future value formuls
                int n = YearsToGrow;
                int c = CompoundType;
                double l = (n * c);
                double R = Additions;
                double y = Math.Pow(1 + i, l);
                double P = Principal;
               
               
                //Future value with additional deposits established
                //converting value to string
                FutureValue = (P * y) + ((R * (y - 1)) / i);
                outFutureValueTB.Text = FutureValue.ToString("C");
                //establishing the annual contribution portion of Future Value Formula
                annualContrib = R * (YearsToGrow * 12);
                outAdditionsTB.Text = annualContrib.ToString("C");


                //outInterestEarnedTB.Text = InterestEarned.ToString("n2");

                //inPrincipalTB.Text = Principal.ToString();

                //inInterestRateTB.Text = InterestRate.ToString("n2");

                //inAdditionsTB.Text = Additions.ToString();

                //monthlyContrib = (((Additions * x) - 1)/ i);
                //FutureValue = (Principal * x) + (monthlyContrib);
                //InterestEarned = FutureValue - (Principal + monthlyContrib);

            }
            catch (Exception)
            {
                MessageBox.Show("Some Information was given in the wrong format!");


            }
        }

        private void compIntLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            inPrincipalTB.Text = "";
            inAdditionsTB.Text = "";
            inYearsGrowthTB.Text = "";
            inInterestRateTB.Text = "";
            outFutureValueTB.Text = "";
            //outInterestEarnedTB.Text = "";
            outAdditionsTB.Text = "";
        }

        private void inPrincipalTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
