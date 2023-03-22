using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{ 
    public static class IsSubsequence
    {
        public static bool Solution(string s, string t)
        {
            //O(Math.Max(s.Length, t.Length))
            #region First Solution
            if (s.Length == 0) return true;
            if (t.Length == 0) return false;
            
            int tIndex = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //This inner loop loops through t until a match is found
                //This loop counter does not reset so it acts like a 
                //second loop rather than a nested loop
                while (tIndex < t.Length - 1 && t[tIndex] != s[i]) tIndex++;
                //Checks when end of t
                if ((tIndex == t.Length - 1) && (i < s.Length - 1 || s[i] != t[tIndex])) return false;
                //This means that s[i] and t[tIndex] do match
                tIndex++;
            }        
            return true;
            #endregion
        }     
    }
}
