using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Is_Perfect_Number
    {
        // A perfect number is a positive integer that is equal to the sum of its proper positive divisors (excluding itself).
        public static bool IsPerfect(int num)
        {
            if (num <= 1)
                return false;

            int sum = 0;

            // Check divisors from 1 to num/2
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }

            return sum == num;
        }
    }
}
