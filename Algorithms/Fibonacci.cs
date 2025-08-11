using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Fibonacci_
    {
        // Fibonacci sequence — a series of numbers where each number is the sum of the two before it
        public static void Fibonacci(int n)
        {
            long first = 0, second = 1, next;

            // Print the first two numbers
            if (n >= 1) Console.Write(first + " ");
            if (n >= 2) Console.Write(second + " ");

            // Print the remaining Fibonacci numbers
            for (int i = 3; i <= n; i++)
            {
                next = first + second;  // Next Fibonacci number
                Console.Write(next + " ");  // Print the next number
                first = second;         // Update first to second
                second = next;          // Update second to next
            }

            Console.WriteLine();  // Move to the next line after the series is printed
        }
    }
}
