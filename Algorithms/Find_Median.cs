using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Find_Median
    {
        public static double FindMedian(int[] arr)
        {
            Array.Sort(arr);

            int n = arr.Length;
            if (n == 0)
                throw new InvalidOperationException("Array is empty.");

            if (n % 2 != 0)
            {
                // Odd number of elements
                return arr[n / 2];
            }
            else
            {
                // Even number of elements
                return (arr[(n / 2) - 1] + arr[n / 2]) / 2.0;
            }
        }
    }
}
