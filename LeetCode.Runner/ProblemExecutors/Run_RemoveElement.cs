using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_RemoveElement
    {
        public static void Run()
        {
            var problem = new RemoveElement();
            var result = problem.Solve([3, 2, 2, 3], 3);
            Console.WriteLine("Input: nums = [3, 2, 2, 3], val = 3");
            Console.WriteLine($"Result: {result}");
        }
    }
}
