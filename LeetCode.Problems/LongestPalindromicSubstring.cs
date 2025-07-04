using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LongestPalindromicSubstring
    {
        public string Solve(string s)
        {
            int length = s.Length;
            if (length == 0) return "";

            int start = 0, maxLength = 1;

            for (int i = 0; i < length; i++)
            {

                // this loop is time for odd and other time for even
                for (int j = 0; j <= 1; j++)
                {
                    int lower = i;
                    int higher = i + j;
                    while (lower >= 0 && higher < length && s[lower] == s[higher])
                    {
                        int currentLength = higher - lower + 1;
                        if (currentLength > maxLength)
                        {
                            maxLength = currentLength;
                            start = lower;
                        }
                        lower--;
                        higher++;
                    }
                }
            }

            return s.Substring(start, maxLength);
        }
    }
}
