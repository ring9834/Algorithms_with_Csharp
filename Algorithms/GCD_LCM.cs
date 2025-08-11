using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class GCD_LCM
    {
        // GCD usually refers to the Greatest Common Divisor (also called Greatest Common Factor, GCF, or Highest Common Factor, HCF)
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;  // The remainder of a divided by b
                            //cout << b << std::endl;
                a = temp;   // Update a to be b
            }
            return a;  // a is the GCD
        }

        // LCM stands for Least Common Multiple (also called Lowest Common Multiple).
        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);  // LCM formula
        }

        // Function to find GCD of an array of numbers
        public static int FindGcdOfArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0; // or throw an exception

            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result = GCD(result, arr[i]);
                if (result == 1)
                    return 1; // Early exit, since 1 is the smallest possible GCD
            }
            return result;
        }
    }
}
