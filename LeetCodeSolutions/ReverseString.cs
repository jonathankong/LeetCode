using System;

namespace LeetCodeSolutions
{
    public static class ReverseString
    {
        public static char[] Solution(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;
            
            while (left < right)
            {
                char temp = s[right];
                s[right] = s[left];
                s[left] = temp;
                
                left++;
                right--;
            }
            return s;
        }
    }
}