using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class  LongestPalindrome
    {
        public static string Solution(string s)
        {
            StringBuilder ans = new StringBuilder();
            int i = 0;

            if (s.Length == 1) return s;

            while (i < s.Length)
            {
                int start = i;
                int end = i;

                //Check to see if nucleus is actually of more than 1 character

                while (true)
                {
                    end += 1;
                    if (end >= s.Length || s[i] != s[end])
                    {
                        end -= 1;
                        break;
                    }
                }

                while (start >= 0 && end < s.Length)
                {
                    if (s[start] == s[end])
                    {
                        int palindromeLength = end - start + 1;
                        if (palindromeLength > ans.Length)
                        {
                            ans.Clear();
                            ans.Append(s.Substring(start, palindromeLength));
                        }
                    }
                    else if (s[start] != s[end])
                    {
                        break;
                    }

                    start -= 1;
                    end += 1;
                }

                i += 1;
            }
            return ans.ToString();
        }
    }
}
