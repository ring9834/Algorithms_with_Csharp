using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Print_Pascals_Triangle
    {
        public static void PrintPascalsTriangle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                // Print leading spaces for formatting
                Console.Write(new string(' ', (n - i) * 2));

                int number = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + "   ");
                    number = number * (i - j) / (j + 1);
                }

                Console.WriteLine();
            }
        }
    }
}
