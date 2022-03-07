using System;
using System.Text;

namespace LeetCodeSolutions
{
    public static class ReverseWordsInString3
    {
        public static string Solution(string s)
        {
            //Find words separated by space
            StringBuilder sb = new StringBuilder(s);
            int left = 0;
            int right = 0;
            
            while (right < s.Length)
            {
                if (s[right] == ' ' || right == s.Length - 1) 
                {
                    ReverseWord(ref sb, left, right == s.Length - 1 ? right : right - 1);
                    left = right + 1;
                    right = left;
                }
                else 
                {
                    right++;    
                }
            }
            return sb.ToString();
        }
        
        private static void ReverseWord(ref StringBuilder s, int left, int right)
        {
            while (left < right)
            {
                char temp = s[right];
                s[right] = s[left];
                s[left] = temp;

                left++;
                right--;
            }
        }
    }
}