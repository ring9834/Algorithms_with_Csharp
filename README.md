## Interesting Algorithms Implemented with C#

## Example - IsPalindrome
```sh
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
```

## Example - IsArmstrong
```sh
    public class Is_Armstrong
    {
        // An Armstrong number is equal to the sum of its own digits each raised to the power of the number of digits.
        public static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;

            // Count the number of digits
            int digits = number.ToString().Length;

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, digits);
                number /= 10;
            }

            return sum == originalNumber;
        }
    }
```

## Example - ReverseNumber
```sh
    public class Reverse_Number
    {
        public static int ReverseNumber(int number)
        {
            int reversed = 0;
            // Reverse the number
            while (number != 0)
            {
                int digit = number % 10;      // Get the last digit of the number
                reversed = reversed * 10 + digit;  // Add the digit to the reversed number
                number /= 10;  // Remove the last digit from the number
            }

            return reversed;
        }
    }
```
More Algorithms can be referred the source code...
