using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Power_of_Number
    {
        public static double PowerofNumber(double baseNum, int exponent)
        {
            double result = 1;

            for (int i = 1; i <= exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}
