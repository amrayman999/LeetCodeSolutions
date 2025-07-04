using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_FindTheIndexOfTheFirstOccurrenceInaString
    {
        public static void Run()
        {
            var problem = new FindTheIndexOfTheFirstOccurrenceInaString();
            var result = problem.Solve("sadbutsad", "sad");
            Console.WriteLine("Input: \"sadbutsad\", \"sad\"");
            Console.WriteLine($"Result: {result}");
        }
    }
}
