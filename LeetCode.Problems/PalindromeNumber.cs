using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class PalindromeNumber
    {
        public bool Solve(int x)
        {

            string num = Convert.ToString(x);
            num = new string(num.ToCharArray().Reverse().ToArray());
            if (num == Convert.ToString(x))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
