using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Is_Palindrome
    {
        // Function to check if a given string is a palindrome
        // a palindrome is a word, phrase, number, or sequence that reads the same forwards and backwards (ignoring spaces, punctuation, and case if desired)
        public static bool isPalindrome(string str)
        {
            int start = 0;
            int end = str.Length - 1;

            // Compare characters from both ends towards the center
            while (start < end)
            {
                if (str[start] != str[end])
                {
                    return false;  // If characters don't match, it's not a palindrome
                }
                start++;
                end--;
            }
            return true;  // If all characters match, it's a palindrome
        }
    }
}
