using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_RemoveDuplicatesFromSortedArray
    {
        public static void Run()
        {
            var problem = new RemoveDuplicatesFromSortedArray();
            var result = problem.Solve(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            Console.WriteLine("Input: nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4]");
            Console.WriteLine($"Result: {result}");
        }
    }
}
