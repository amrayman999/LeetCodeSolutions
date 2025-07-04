using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_AddBinary
    {
        public static void Run()
        {
            var problem = new AddBinary();
            var result = problem.Solve("1010", "1011");
            Console.WriteLine("Input: \"1010\", \"1011\"");
            Console.WriteLine($"Result: {result}");
        }
    }
}
