using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_LongestSubstringWithoutRepeatingCharacters
    {
        public static void Run()
        {
            var problem = new LongestSubstringWithoutRepeatingCharacters();
            var result = problem.Solve("abcabcbb");
            Console.WriteLine("Input: \"abcabcbb\"");
            Console.WriteLine($"Result: {result}");
        }
    }
}
