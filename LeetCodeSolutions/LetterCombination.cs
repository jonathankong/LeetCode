using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{ 
    public static class LetterCombinations
    {
        private static string[] digitText = new string[] {
            "", 
            "",
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz"
        };
        // public static IList<string> Solution(string digits)
        // {
        //     IList<string> answers = new List<string>();
        //     return Recursive(digits, ref answers);
        // }     
        // private static IList<string> Recursive(string digits, ref IList<string> answers)
        // {
        //     IList<string> tempAnswers = new List<string>();
        //     if (digits.Length == 0);

        //     int digit = int.Parse(digits[0].ToString());

        //     foreach (char i in digitText[digit])
        //     {

        //         tempAnswers.Add(Recursive(digits.Substring(1), ref answers));

        //     }

        //     return "";
        // }
    }

    
}
