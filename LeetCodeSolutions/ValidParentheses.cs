using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class ValidParentheses
    {
        public static bool Solution(string s)
        {
            #region First Answer
                // if (s.Length % 2 == 1) return false;
                // Stack<char> charStack = new Stack<char>();

                // foreach(char c in s)
                // {
                //     if (charStack.Count == 0 || c == '(' || c == '[' || c == '{')
                //     {
                //         charStack.Push(c);
                //     }
                //     else if (charStack.Peek() == '(' && c == ')' ||
                //         charStack.Peek() == '{' && c == '}' ||
                //         charStack.Peek() == '[' && c == ']')
                //     {
                //         charStack.Pop();
                //     }
                //     else
                //     {
                //         break;
                //     }
                // }
                // return charStack.Count == 0;
            #endregion

            #region Second Answer
            //I think this answer is better as it is easier to read.
                if (s.Length % 2 != 0) return false;

                var pairStack = new Stack<char>();

                //We're only concerned with closing brackets in the string
                foreach (var c in s)
                {
                    var openingBracket = '\0';

                    switch (c)
                    {
                        case ')':
                            openingBracket = '(';
                            break;
                        case '}':
                            openingBracket = '{';
                            break;
                        case ']':
                            openingBracket = '[';
                            break;
                        default:
                            break;
                    }

                    //If the character is an opening bracket
                    if (pairStack.Count == 0 || openingBracket == '\0')
                    {
                        pairStack.Push(c);
                    }
                    //If it's a closed bracket
                    else if (pairStack.Count > 0 && pairStack.Peek() == openingBracket)
                    {
                        pairStack.Pop();    
                    }
                    else return false;
                    
                } 

                return pairStack.Count == 0;
            #endregion
        }
    }
}
