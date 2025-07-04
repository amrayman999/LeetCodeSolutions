using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public static class Run_TwoSum
    {
        public static void Run()
        {
            var problem = new TwoSum();
            var result = problem.Solve(new[] { 2, 7, 11, 15 }, 9);
            Console.WriteLine("Input: nums = [2,7,11,15], target = 9");
            Console.WriteLine($"Result: [{string.Join(", ", result)}]");
        }
    }
}
