using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodeSolutions
{
    class ValidPalindrome
    {
        public static bool Solution(string s)
        {
            string newString = Regex.Replace(s, @"\s+", "");
            
            if (newString.Length < 2) return true;

            int start = 0;
            int end = newString.Length - 1;

            while (end > start)
            {
                if (char.ToLower(newString[start]) == char.ToLower(newString[end]))
                {
                    start++;
                    end--;
                }
                else return false;
            }    

            return true;
        }
    }
}
