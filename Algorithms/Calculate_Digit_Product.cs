using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Calculate_Digit_Product
    {
        public static int CalculateDigitProduct(int number)
        {
            number = Math.Abs(number); // Handle negative numbers
            int product = 1;

            if (number == 0)
                return 0;

            while (number > 0)
            {
                int digit = number % 10;
                product *= digit;
                number /= 10;
            }

            return product;
        }
    }
}
