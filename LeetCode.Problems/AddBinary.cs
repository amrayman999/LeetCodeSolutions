using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class AddBinary
    {
        public string Solve(string a, string b)
        {

            StringBuilder s = new StringBuilder();
            int a_i = a.Length - 1;
            int b_i = b.Length - 1;
            int remainder = 0;
            while (a_i >= 0 || b_i >= 0 || remainder == 1)
            {
                if (a_i >= 0)
                {
                    remainder += a[a_i] - '0';
                    a_i--;
                }
                if (b_i >= 0)
                {
                    remainder += b[b_i] - '0';
                    b_i--;
                }
                s.Append(remainder % 2);
                remainder /= 2;
            }
            return new string(s.ToString().Reverse().ToArray());

        }
    }
}
