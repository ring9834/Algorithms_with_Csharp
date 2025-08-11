using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Find_Second_Largest
    {
        public static int FindSecondLargest(int[] arr)
        {
            if (arr.Length < 2)
                return int.MinValue; // Not enough elements

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num < largest)
                {
                    secondLargest = num;
                }
            }

            return secondLargest;
        }
    }
}
