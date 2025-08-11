using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Check_Leap_Year
    {
        public static bool IsLeapYear(int year)
        {
            // Leap year rules:
            // 1. Divisible by 4 but not by 100
            // 2. Or divisible by 400
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
