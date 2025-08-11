using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Count_Odds_Evens
    {
        public static int CountOdds(int[] dataArray)
        {
            int count = 0;
            foreach (int num in dataArray)
            {
                if (num % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountEvens(int[] dataArray)
        {
            int count = 0;
            foreach (int num in dataArray)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }

}
