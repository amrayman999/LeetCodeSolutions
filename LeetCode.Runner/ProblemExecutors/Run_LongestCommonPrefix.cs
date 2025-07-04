using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_LongestCommonPrefix
    {
        public static void Run()
        {
            var problem = new LongestCommonPrefix();
            var result = problem.Solve(["flower", "flow", "flight"]);
            Console.WriteLine("Input: strs = [\"flower\",\"flow\",\"flight\"], target = 9");
            Console.WriteLine($"Result: {result}");
        }
    }
}
