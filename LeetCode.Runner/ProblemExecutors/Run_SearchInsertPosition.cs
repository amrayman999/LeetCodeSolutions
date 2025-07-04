using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_SearchInsertPosition
    {
        public static void Run()
        {
            var problem = new SearchInsertPosition();
            var result = problem.Solve([1, 3, 5, 6], 5);
            Console.WriteLine("Input: nums = [1, 3, 5, 6], target = 5");
            Console.WriteLine($"Result: {result}");
        }
    }
}
