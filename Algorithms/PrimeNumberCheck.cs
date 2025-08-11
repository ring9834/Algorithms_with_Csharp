using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PrimeNumberCheck
    {
        public static bool IsPrime(int num)
        {
            if (num <= 1)
                return false; // 0, 1, and negative numbers are not prime

            // Check divisibility up to the square root of the number
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
