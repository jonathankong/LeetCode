using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class ReverseInteger
    {
        public static int Solution(int x)
        {

            int length = Math.Abs(x).ToString().Length;

            int answer = 0;


            for (int i = 1; i <= length; i++)
            {


                int tempDigit = x % (int)Math.Pow(10, i) / (int)Math.Pow(10, i - 1);

                if (tempDigit * Math.Pow(10, length - i) <= Math.Pow(-2, 31) || tempDigit * Math.Pow(10, length - i) > Math.Pow(2, 31) - 1)
                {
                    answer = 0;
                    break;
                }

                answer = answer + tempDigit * (int)Math.Pow(10, length - i);
            }

            return (int)answer;
        }
    }
}
