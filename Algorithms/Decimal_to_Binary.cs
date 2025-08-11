using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Decimal_to_Binary
    {
        public static string ConvertToBinary(int number)
        {
            if (number == 0)
                return "0";

            string binary = "";

            int num = number;
            while (num > 0)
            {
                int remainder = num % 2;
                binary = remainder + binary;  // prepend remainder
                num /= 2;
            }

            return binary;
        }
    }
}
}
