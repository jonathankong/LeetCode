using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{ 
    public static class IsIsomorphic
    {
        public static bool Solution(string s, string t)
        {
            //Using 2 dictionarys at O(n) time
            //Each string has its own dictionary
            #region First Solution
            Dictionary<int, int> charSMap = new Dictionary<int, int>();
            Dictionary<int, int> charTMap = new Dictionary<int, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if ((!charSMap.TryAdd(s[i], t[i]) && charSMap[s[i]] != t[i]) ||
                    (!charTMap.TryAdd(t[i], s[i]) && charTMap[t[i]] != s[i])) return false;
            }
            return true;
            #endregion
        }     
    }
}
