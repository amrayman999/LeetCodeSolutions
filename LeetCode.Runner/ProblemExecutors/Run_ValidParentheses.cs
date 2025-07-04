using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_ValidParentheses
    {
        public static void Run()
        {
            var problem = new ValidParentheses();
            var result = problem.Solve("()[]{}");
            Console.WriteLine("Input: \"()[]{}\"");
            Console.WriteLine($"Result: {result}");
        }
    }
}
