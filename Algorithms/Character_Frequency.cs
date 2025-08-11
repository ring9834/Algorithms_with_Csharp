using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Character_Frequency
    {
        /// <summary>
        /// Calculates the frequency of each character in a string
        /// </summary>
        /// <param name="input">The input string to analyze</param>
        /// <returns>Dictionary with characters as keys and their frequencies as values</returns>
        public static Dictionary<char, int> FindCharFrequency(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string cannot be null or empty");
            }

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            // Count frequency of each character
            foreach (char c in input)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;
                }
            }

            return frequency;
        }
    }
}
