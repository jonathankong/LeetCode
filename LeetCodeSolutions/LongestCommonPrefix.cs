using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{
    public static class LongestCommonPrerfix
    {
        public static string Solution(string[] strs)
        {
            int prefixIndex = 0;

            int smallestStrLen = strs.Min(x => x.Length);

            bool isCharSame = true;

            while (prefixIndex < smallestStrLen)
            {
                char c = '\0';
                for (int i = 0; i < strs.Length; i++)
                {
                    char tempChar = strs[i][prefixIndex];
                    if (c == '\0') c = tempChar;
                    else if (c != tempChar)
                    {
                        isCharSame = false;
                        break;
                    }
                }
                if (!isCharSame) break;
                prefixIndex++;
            }

            return isCharSame == false && prefixIndex == 0 ? "" : strs[0].Substring(0, prefixIndex);
        }     
    }
}
