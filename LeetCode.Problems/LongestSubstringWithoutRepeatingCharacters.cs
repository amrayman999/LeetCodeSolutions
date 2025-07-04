using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int Solve(string s)
        {
            int longestStringLength = 0;
            int startOfWindow = 0;
            int currentPosition = 0;

            HashSet<char> characterSet = new HashSet<char>();

            while (currentPosition < s.Length)
            {
                if (characterSet.Contains(s[currentPosition]))
                {
                    characterSet.Remove(s[startOfWindow]);
                    startOfWindow++;
                }
                else
                {
                    characterSet.Add(s[currentPosition]);
                    currentPosition++;
                    longestStringLength = Math.Max(longestStringLength, characterSet.Count);
                }
            }

            return longestStringLength;
        }
    }
}
