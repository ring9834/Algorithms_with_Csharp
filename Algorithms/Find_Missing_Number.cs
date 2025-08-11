using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Find_Missing_Number
    {
        public static int FindMissingNumber(int[] arr, int n)
        {
            // Calculate expected sum of numbers from 1 to n using the formula: n * (n + 1) / 2
            int expectedSum = (n * (n + 1)) / 2;

            // Calculate actual sum of array elements
            int actualSum = 0;
            foreach (int num in arr)
            {
                actualSum += num;
            }

            // The missing number is the difference between expected and actual sum
            return expectedSum - actualSum;
        }
    }
}
