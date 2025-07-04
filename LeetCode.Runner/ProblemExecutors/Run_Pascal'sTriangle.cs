using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_Pascal_sTriangle
    {
        public static void Run()
        {
            var problem = new Pascal_sTriangle();
            var result = problem.Solve(5);
            Console.WriteLine("Input: numRows = 5");
            Console.Write("Output: ");
            Console.Write("[");
            foreach (var row in result)
            {
                Console.Write("[");
                Console.Write(string.Join(", ", row));
                Console.Write("] ");
            }
            Console.WriteLine("]");
        }
    }
}
