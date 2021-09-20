using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{

    static class GenerateParenthesis
    {
        static IDictionary<int, char> chars = new Dictionary<int, char>()
        {
            { 1, '(' },
            { 2, ')' }
        };

        public static IList<string> Solution(int n)
        {
            IList<string> answers = new List<string>();
            Recursion(answers, n);
            
            return answers;
        }

        private static void Recursion(IList<string> answers, int n)
        {
            Recursion(answers, "", n, n);
        }

        private static void Recursion(IList<string> answers, string str, int openBrackets, int closeBrackets)
        {
            char lastChar = '\0';
            if (str.Length > 0)
            {
                lastChar = str[str.Length - 1];
            }
            //End recursion statement
            if (openBrackets == 0 && closeBrackets == 0)
            {
                answers.Add(str.ToString());
                return;
            }
            //Balance pairs to be made
            else if (str.Length == 0 || lastChar == chars[2] && openBrackets == closeBrackets)
            {
                Recursion(answers, str + chars[1], openBrackets - 1, closeBrackets);
            }
            //If last character is an open character and there are more pairs left to create
            //or there are unbalanced pairs left in the string
            else if ((lastChar == chars[1] || openBrackets < closeBrackets) && openBrackets > 0)
            {
                Recursion(answers, str + chars[1], openBrackets - 1, closeBrackets);
                Recursion(answers, str + chars[2], openBrackets, closeBrackets - 1);
            }
            else
            {
                Recursion(answers, str + chars[2], openBrackets, closeBrackets - 1);
            }
        }
    }
}
