using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Is_Armstrong
    {
        // An Armstrong number is equal to the sum of its own digits each raised to the power of the number of digits.
        public static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;

            // Count the number of digits
            int digits = number.ToString().Length;

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                number /= 10;
            }

            return sum == originalNumber;
        }
    }
}
