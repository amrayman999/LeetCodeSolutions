using LeetCode.Core;
using LeetCode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Runner.ProblemExecutors
{
    public class Run_AddTwoNumbers
    {
        public static void Run()
        {
            var problem = new AddTwoNumbers();
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var result = problem.Solve(l1,l2);
            Console.WriteLine("Input:l1 =  [2,4,3], l2 = [5,6,4]");
            Console.Write($"Result: ");
            while (result != null)
            {
                Console.Write(result.val);
                result = result.next;
                if (result != null)
                {
                    Console.Write(" -> ");
                }
            }

        }
    }
}
