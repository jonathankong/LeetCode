using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class LargestPalindromeSubString
    {
        public static string Solution(string s)
        {
            StringBuilder largestPal = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                //Check odd nucleus
                var start = i;
                var end = i;

                while (s[start] == s[end] && start >= 0 && end <= s.Length - 1)
                {
                    if (largestPal.Length < 1)
                    {
                        largestPal.Append(s[start]);
                    }
                    else if (start != end && s.Substring(start, end).Length > largestPal.Length)
                    {
                        largestPal.Clear();
                        largestPal.Append(s.Substring(start, end));
                    }
                    start = start - 1 < 0 ? 0 : start - 1;
                    end = end + 1 > s.Length - 1 ? s.Length - 1 : end + 1;

                    if (start == 0 && end == s.Length - 1) break;
                }

                start = i;
                end = i + 1 >= s.Length - 1 ? s.Length - 1 : i + 1;

                if (start == end) break;

                //Check even nucleus
                while (s[start] == s[end] && start >= 0 && end <= s.Length - 1)
                {
                    if (largestPal.Length < 1)
                    {
                        largestPal.Append(s[start]);
                    }
                    else if (s.Substring(start, end).Length > largestPal.Length)
                    {
                        largestPal.Clear();
                        largestPal.Append(s.Substring(start, end));
                    }
                    start = start - 1 < 0 ? 0 : start - 1;
                    end = end + 1 > s.Length - 1 ? s.Length - 1 : end + 1;

                    if (start == 0 && end == s.Length - 1) break;
                }
            }

            return largestPal.ToString();
        }
    }
}
