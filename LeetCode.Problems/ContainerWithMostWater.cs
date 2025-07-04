using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class ContainerWithMostWater
    {
        public int Solve(int[] height)
        {

            int ptrL = 0;
            int ptrR = height.Length - 1;
            int max_amount = 0;
            char flag = ' ';
            while (ptrL <= ptrR)
            {
                int lessHeight_index = 0;
                if (height[ptrL] <= height[ptrR])
                {
                    lessHeight_index = ptrL;
                    flag = 'L';
                }
                else
                {
                    lessHeight_index = ptrR;
                    flag = 'R';
                }
                int amount = ((ptrR + 1) - (ptrL + 1)) * height[lessHeight_index];
                if (amount >= max_amount)
                    max_amount = amount;
                if (flag == 'R')
                {
                    ptrR--;
                }
                else
                {
                    ptrL++;
                }
            }
            return max_amount;
        }
    }
}
