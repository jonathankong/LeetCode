using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class MyAtoi
    {
        public static int Solution(string s)
        {
            long ans = 0;
            int index = 0;
            int baseNum = 0;
            int sign = 1;

            //Check for leading spaces
            while (index < s.Length && s[index] == ' ') index += 1;

            //Check for - and + signs
            if (index < s.Length && s[index] == '-')
            {
                sign *= -1;
                index += 1;
            }
            else if (index < s.Length && s[index] == '+') index += 1;

            //Parse each digit from left to right while checking if ans surpasses max num int can hold
            while (index < s.Length && s[index] >= '0' && s[index] <= '9')
            {
                ans *= 10;
                ans += int.Parse(s[index].ToString());
                index += 1;
                if (ans > 0) baseNum += 1; //There could be leading zeroes in s 
                if (baseNum > 10) break; //Max num of digits for an int to hold
            }

            ans *= sign;
            if (ans > int.MaxValue) ans = int.MaxValue;
            else if (ans < int.MinValue) ans = int.MinValue;

            return (int)ans;
        }
    }
}
