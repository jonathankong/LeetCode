using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class Roman2Integer
    {
        private static Dictionary<char, int> romanToInt = new Dictionary<char, int>(){
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        public static int Solution(string s)
        {
            //This solution was going from right to left.  
            //I found out later I was making it hard on myself
            #region First Solution
            // int ans = 0;
            // int end = s.Length - 1;
            // int tempAns = 0;

            // ans += ReadRomanToInt(s, 'I', 'V', 'X', ref end);
            // ans += ReadRomanToInt(s, 'X', 'L', 'C', ref end);
            // ans += ReadRomanToInt(s, 'C', 'D', 'M', ref end);
            // ans += ReadRomanToInt(s, 'M', '\0', '\0', ref end);
            // return ans;
            #endregion

            int ans = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int next = i + 1;
                if (next < s.Length && romanToInt[s[i]] < romanToInt[s[next]]) ans -= romanToInt[s[i]];
                else ans += romanToInt[s[i]];
            }

            return ans;
        }

        private static int ReadRomanToInt (string s, char one, char five, char ten,ref int end)
        {
            int ans = 0;

            while (end >= 0)
            {
                if (s[end] == ten || s[end] == five)
                {
                    ans += romanToInt[s[end]];
                    int start = end - 1;
                    if (start >= 0 && s[start] == one) 
                    {
                        ans -= romanToInt[s[start]];
                        end = start;
                    }
                    end--;
                }
                while (end >= 0 && (s[end] == one || s[end] == five)) 
                {
                    ans += romanToInt[s[end]];
                    end--;  
                }
                if (end >= 0 && s[end] != one && s[end] != five && s[end] != ten) break;
            }
            return ans;
        }
    }
}