using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    public class ValidParentheses
    {
        public bool Solve(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char item in s)
            {
                if (item == '{' || item == '[' || item == '(')
                {
                    stack.Push(item);
                }
                else if (item == '}')
                {
                    if (stack.Count != 0 && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (item == ']')
                {
                    if (stack.Count != 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (item == ')')
                {
                    if (stack.Count != 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
