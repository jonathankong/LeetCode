using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class PhoneNumberLetterCombinations
    {
        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> answers = new Queue<string>() { "" };
            if (digits.Length == 0) return answers;

            String[] letterGroupings = ["", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];

            foreach(char c in digits)
            {
                var tempChar = answers.Remove();
            }
        }
    }
}
