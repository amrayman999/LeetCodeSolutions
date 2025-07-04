using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_MergeSortedArray
    {
        public static void Run()
        {
            var problem = new MergeSortedArray();
            int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[3] { 2, 5, 6 };
            int n = 3;
            problem.Solve(nums1,m,nums2,n);
            Console.WriteLine("Input: nums1 = [1, 2, 3, 0, 0, 0 ] , m = 3 , nums2 = [2, 5, 6] , n = 3");
            Console.WriteLine($"Result: [{string.Join(", ", nums1)}]");
        }
    }
}
