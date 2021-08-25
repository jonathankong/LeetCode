using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class LongestSubstringWithoutRepeatChars
    {
        public static int Solution(string s)
        {
            int longestSubStringLength = 0;
            Queue<char> tempSubString = new Queue<char>();

            foreach (char c in s)
            {
                if (tempSubString.Contains(c) && tempSubString.Count > longestSubStringLength)
                {
                    longestSubStringLength = tempSubString.Count;
                }
                while (tempSubString.Contains(c))
                {
                    tempSubString.Dequeue();
                }
                tempSubString.Enqueue(c);
            }

            return Math.Max(tempSubString.Count, longestSubStringLength);
        }
    }
}
