using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class Pascal_sTriangle
    {
        public IList<IList<int>> Solve(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add([1]);
            if (numRows == 1)
            {
                return result;
            }
            result.Add([1, 1]);
            if (numRows == 2)
            {
                return result;
            }
            for (int i = 2; i < numRows; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < i + 1; j++)
                {
                    if (j == i || j == 0)
                    {
                        row.Add(1);
                    }
                    else
                    {
                        row.Add(result[i - 1][j - 1] + result[i - 1][j]);
                    }
                }
                result.Add(row);
            }
            return result;
        }

    }
}
