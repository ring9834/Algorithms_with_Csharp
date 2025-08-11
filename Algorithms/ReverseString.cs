using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Reverse_String
    {
        public static void ReverseString(char[] ptr)
        {
            if (ptr == null || ptr.Length == 0) return;

            int start = 0;
            int end = ptr.Length - 1;

            while (start < end)
            {
                char temp = ptr[start];
                ptr[start] = ptr[end];
                ptr[end] = temp;
                start++;
                end--;
            }
        }

        public static void ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str)) return;
            char[] ptr = str.ToCharArray();
            //if (ptr == null || ptr.Length == 0) return;

            int start = 0;
            int end = ptr.Length - 1;

            while (start < end)
            {
                char temp = ptr[start];
                ptr[start] = ptr[end];
                ptr[end] = temp;
                start++;
                end--;
            }
        }
    }
}
