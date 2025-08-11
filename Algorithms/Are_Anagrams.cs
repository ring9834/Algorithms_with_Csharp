using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Are_Anagrams
    {
        public static bool AreAnagrams(string s1, string s2)
        {
            // Remove whitespace and convert to lowercase for case-insensitive comparison
            s1 = s1.Replace(" ", "").ToLower();
            s2 = s2.Replace(" ", "").ToLower();

            if (s1.Length != s2.Length)
                return false;

            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }
    }
}
