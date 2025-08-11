using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Merge_Sorted_Arrays
    {
        /// <summary>
        /// Merges two sorted arrays into a single sorted array
        /// </summary>
        /// <param name="arr1">First sorted array</param>
        /// <param name="arr2">Second sorted array</param>
        /// <returns>A new sorted array containing all elements from both input arrays</returns>
        public static int[] MergeSortedArrays(int[] arr1, int[] arr2)
        {
            // Input validation
            if (arr1 == null || arr2 == null)
            {
                throw new ArgumentNullException("Input arrays cannot be null");
            }

            // Create result array with size equal to sum of input arrays
            int[] result = new int[arr1.Length + arr2.Length];
            int i = 0; // Index for arr1
            int j = 0; // Index for arr2
            int k = 0; // Index for result

            // Merge arrays while both have elements
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    result[k++] = arr1[i++];
                }
                else
                {
                    result[k++] = arr2[j++];
                }
            }

            // Copy remaining elements from arr1, if any
            while (i < arr1.Length)
            {
                result[k++] = arr1[i++];
            }

            // Copy remaining elements from arr2, if any
            while (j < arr2.Length)
            {
                result[k++] = arr2[j++];
            }

            return result;
        }
    }
}
