using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{ 
    public static class FindIndexOfFirstOccurence
    {
        public static int Solution(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle) return i;
            }
            return -1;
        }     
    }
}
