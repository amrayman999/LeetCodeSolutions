using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_RomanToInteger
    {
        public static void Run()
        {
            var problem = new RomanToInteger();
            var result = problem.Solve("III");
            Console.WriteLine("Input: \"III\"");
            Console.WriteLine($"Result: {result}");
        }
    }
}
