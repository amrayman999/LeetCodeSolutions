using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class LongestCommonPrefix
    {
        public string Solve(string[] strs)
        {
            if (strs.Length == 1)
            {
                return strs[0];
            }
            string result = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                foreach (string str in strs)
                {
                    if (i >= str.Length || strs[0][i] != str[i])
                    {
                        return result;
                    }
                }
                result += strs[0][i];
            }

            return result;

        }
    }
}
