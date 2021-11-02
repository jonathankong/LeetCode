using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    static class GroupAnagrams
    {
        public static IList<IList<string>> Solution(string[] strs)
        {
            Dictionary<int, IList<string>> keyValuePairs = new Dictionary<int, IList<string>>();
            var asciiA = 'a';

            //Calculate total char value for each string and add it to the dictionary

            for (int i = 0; i < strs.Length; i++)
            {
                var countChars = new int[26];
                foreach(char c in strs[i])
                {
                    countChars[c - asciiA]++;
                }

                var hash = CalculateHash(countChars);

                if (keyValuePairs.ContainsKey(hash))
                {
                    keyValuePairs[hash].Add(strs[i]);
                }
                else
                {
                    keyValuePairs.Add(hash, new List<string>() { strs[i] });
                }
            }

            IList<IList<string>> answers = new List<IList<string>>();
            foreach(var val in keyValuePairs.Values)
            {
                answers.Add(new List<string>(val));
            }

            return answers;
        }

        private static int CalculateHash(int[] countChars)
        {
            int hash = 17;
            for (int i = 0; i < countChars.Length; i++)
            {
                hash = hash * 19 + countChars[i];
            }
            return hash;
        }
    }
}
