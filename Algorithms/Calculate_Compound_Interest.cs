using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Calculate_Compound_Interest
    {
        /// <summary>
        /// Calculates compound interest
        /// </summary>
        /// <param name="principal">Initial investment amount</param>
        /// <param name="rate">Annual interest rate (as a decimal, e.g., 0.05 for 5%)</param>
        /// <param name="time">Time in years</param>
        /// <param name="n">Number of times interest is compounded per year</param>
        /// <returns>Final amount after compound interest</returns>
        public static double CalculateCompoundInterest(double principal, double rate, double time, int n)
        {
            if (principal < 0 || rate < 0 || time < 0 || n <= 0)
            {
                throw new ArgumentException("Inputs must be non-negative, and compounding frequency must be positive");
            }

            // Formula: A = P(1 + r/n)^(nt)
            double amount = principal * Math.Pow(1 + (rate / n), n * time);
            return Math.Round(amount, 2); // Round to 2 decimal places
        }
    }
}
