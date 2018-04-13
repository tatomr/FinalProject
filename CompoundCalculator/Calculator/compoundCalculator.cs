using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CompoundCalculator
    {
        public static double CalculateTotalWithCompoundInterest(double principal, double interestRate, double compoundingFrequency, double yearCount, double monthlyAdditions)
        {
            try
            {



                // Annual Additions
                double R;
                //Future Value
                double futureValue;

                // Evaluating the compounding frequencies then add the monthly payments
                if (compoundingFrequency == 12)
                {
                    R = monthlyAdditions;
                }
                else if (compoundingFrequency == 4)
                {
                    R = (monthlyAdditions * 3);
                }
                else if (compoundingFrequency == 2)
                {
                    R = (monthlyAdditions * 6);
                }
                else
                {
                    R = (monthlyAdditions * 12);
                }

                // establishing i in the Future Value formula
                double i = (interestRate / compoundingFrequency);
                //establishing other variables in Future value formuls
                double n = yearCount;
                double c = compoundingFrequency;
                double l = (n * c);
                double y = Math.Pow(1 + i, l);
                double P = principal;
                double Z = (y - 1);
                
                futureValue = (P * y) + ((R * Z) / i);
                //Calculations Returned
                return futureValue;

            }
            //Error Handeling 
            catch (Exception ex)
            {

                 throw ex;
            }
        }

    }
}
