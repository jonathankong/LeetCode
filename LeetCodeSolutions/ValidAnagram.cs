using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    static class ValidAnagram
    {
        public static bool Solution(string s, string t)
        {
            //First Solution with arrays
            // char[] sArr = s.ToArray();
            // char[] tArr = t.ToArray();

            // Array.Sort(sArr);
            // Array.Sort(tArr);

            // return sArr.SequenceEqual(tArr);

            //Second Solution with dictionaries check to see if text are same length
            if (s.Length != t.Length) return false;

            Dictionary<char, int> anagramDict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                anagramDict.TryAdd(s[i], 0);
                anagramDict.TryAdd(t[i], 0);
                anagramDict[s[i]] += 1;
                anagramDict[t[i]] -= 1;
            }

            foreach (KeyValuePair<char, int> kvp in anagramDict)
            {
                if (kvp.Value % 2 != 0) return false;
            }
            
            IList<IList<string>> e = new List<IList<string>>();

            return true;

        }
    }
}
