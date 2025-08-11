using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Square_Root_of_Number
    {
        public static double GetSquareRoot(double number)
        {
            if (number < 0)
                return double.NaN; // Not a real number

            if (number == 0)
                return 0;

            double guess = number / 2.0;
            double epsilon = 0.000001; // precision

            while (Math.Abs(guess * guess - number) > epsilon)
            {
                guess = (guess + number / guess) / 2.0;
            }

            return guess;
        }
    }
}
