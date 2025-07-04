using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RomanToInteger
    {
        public int Solve(string s)
        {

            Dictionary<char, int> roman = new Dictionary<char, int>(){
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
             };
            char pointer = 'I';
            int total = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (roman[s[i]] < roman[pointer])
                {
                    total -= roman[s[i]];
                    pointer = s[i];
                }
                else
                {
                    total += roman[s[i]];
                    pointer = s[i];
                }
            }
            return total;

        }
    }
}
