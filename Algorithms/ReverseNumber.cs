using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algorithms
{
    public class Reverse_Number
    {
        public static int ReverseNumber(int number)
        {
            int reversed = 0;
            // Reverse the number
            while (number != 0)
            {
                int digit = number % 10;      // Get the last digit of the number
                reversed = reversed * 10 + digit;  // Add the digit to the reversed number
                number /= 10;  // Remove the last digit from the number
            }

            return reversed;
        }
    }
}
