using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class RemoveElement
    {
        public int Solve(int[] nums, int val)
        {
            List<int> numList = new List<int>(nums);
            numList.RemoveAll(item => item == val);
            numList.CopyTo(nums);
            return numList.Count;
        }
    }
}
