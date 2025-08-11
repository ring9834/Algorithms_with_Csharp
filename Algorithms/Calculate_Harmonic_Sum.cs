using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Calculate_Harmonic_Sum
    {
        // calculates the sum of the harmonic series up to N terms
        public static double CalculateHarmonicSum(int n)
        {
            double sum = 0.0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            return sum;
        }
    }
}
