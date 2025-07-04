using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_LongestPalindromicSubstring
    {
        public static void Run()
        {
            var problem = new LongestPalindromicSubstring();
            var result = problem.Solve("babad");
            Console.WriteLine("Input: \"babad\"");
            Console.WriteLine($"Result: {result}");
        }
    }
}
