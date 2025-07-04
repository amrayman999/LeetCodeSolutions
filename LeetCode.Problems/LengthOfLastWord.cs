using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LengthOfLastWord
    {
        public int Solve(string s)
        {

            int length = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    int j = i;
                    while (j >= 0 && s[j] != ' ')
                    {
                        length++;
                        j--;
                    }
                    break;
                }
            }
            return length;
        }
    }
}
