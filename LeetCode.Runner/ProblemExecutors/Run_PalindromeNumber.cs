using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_PalindromeNumber
    {
        public static void Run()
        {
            var problem = new PalindromeNumber();
            var result = problem.Solve(121);
            Console.WriteLine("Input: num = 121");
            Console.WriteLine($"Result: {result}");
        }
    }
}
