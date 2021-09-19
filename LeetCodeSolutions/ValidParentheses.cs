using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class ValidParentheses
    {
        public static bool Solution(string s)
        {
            if (s.Length % 2 == 1) return false;
            Stack<char> charStack = new Stack<char>();

            foreach(char c in s)
            {
                if (charStack.Count == 0 || c == '(' || c == '[' || c == '{')
                {
                    charStack.Push(c);
                }
                else if (charStack.Peek() == '(' && c == ')' ||
                    charStack.Peek() == '{' && c == '}' ||
                    charStack.Peek() == '[' && c == ']')
                {
                    charStack.Pop();
                }
                else
                {
                    break;
                }
            }
            return charStack.Count == 0;
        }
    }
}
