using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class IsPalindrome
    {
        public static bool Solution(int x)
        {
            //Automatically, if a number is negative, it's not palindrome.
            if (x < 0) return false;
            //If a num is single digit, it is a palindrome.
            if (x < 10) return true;

            //Convert num to string and then use 2 pointers to compare either end of string
            var str = $"{x}";

            var left = 0;
            var right = str.Length - 1;

            while (left <= right)
            {
                if (str[left] != str[right]) return false;
                left++;
                right--;
            }
            return true;
        }
    }
}