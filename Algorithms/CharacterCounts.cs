using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Character_Counts
    {
        public static CharacterCounts AnalyseText(string text)
        {
            CharacterCounts counts = new CharacterCounts();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char lower = char.ToLower(c);
                    if ("aeiou".Contains(lower))
                    {
                        counts.Vowels++;
                    }
                    else
                    {
                        counts.Consonants++;
                    }

                    if (char.IsUpper(c)) counts.Uppercase++;
                    else if (char.IsLower(c)) counts.Lowercase++;
                }
                else if (char.IsDigit(c))
                {
                    counts.Digits++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    counts.Spaces++;
                }
            }
            return counts;
        }
    }

    // Struct-like class to hold character counts
    public class CharacterCounts
    {
        public int Vowels { get; set; }
        public int Consonants { get; set; }
        public int Uppercase { get; set; }
        public int Lowercase { get; set; }
        public int Spaces { get; set; }
        public int Digits { get; set; }
    }
}
