using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_ContainerWithMostWater
    {
        public static void Run()
        {
            var problem = new ContainerWithMostWater();
            var result = problem.Solve([1, 8, 6, 2, 5, 4, 8, 3, 7]);
            Console.WriteLine("Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]");
            Console.WriteLine($"Result: {result}");
        }
    }
}
