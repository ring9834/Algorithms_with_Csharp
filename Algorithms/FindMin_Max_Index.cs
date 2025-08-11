using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FindMin_Max_Index
    {
        public static int FindMinIndex(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return -1; // Return -1 for invalid input

            int minIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int FindMaxIndex(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return -1; // Return -1 for invalid input

            int maxIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}
