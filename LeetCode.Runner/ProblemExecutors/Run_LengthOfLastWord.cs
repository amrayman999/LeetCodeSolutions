using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_LengthOfLastWord
    {
        public static void Run()
        {
            var problem = new LengthOfLastWord();
            var result = problem.Solve("Hello World");
            Console.WriteLine("Input: \"Hello World\"");
            Console.WriteLine($"Result: {result}");
        }
    }
}
