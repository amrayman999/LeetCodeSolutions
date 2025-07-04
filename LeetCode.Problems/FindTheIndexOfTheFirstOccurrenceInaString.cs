using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class FindTheIndexOfTheFirstOccurrenceInaString
    {
        public int Solve(string haystack, string needle)
        {

            if (string.IsNullOrEmpty(needle)) return 0;
            if (haystack.Length < needle.Length) return -1;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }

            return -1;

        }
    }
}
