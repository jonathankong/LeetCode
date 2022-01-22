using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class ReverseInteger
    {
        public static int Solution(int x)
        {
            #region OldCodeNotWorking
            //int length = Math.Abs(x).ToString().Length;

            //int answer = 0;


            //for (int i = 1; i <= length; i++)
            //{


            //    int tempDigit = x % (int)Math.Pow(10, i) / (int)Math.Pow(10, i - 1);

            //    if (tempDigit * Math.Pow(10, length - i) <= Math.Pow(-2, 31) || tempDigit * Math.Pow(10, length - i) > Math.Pow(2, 31) - 1)
            //    {
            //        answer = 0;
            //        break;
            //    }

            //    answer = answer + tempDigit * (int)Math.Pow(10, length - i);
            //}

            //return (int)answer;
            #endregion

            #region New Answer
            int ans = 0;
            int baseNum = 0;
            int sign = x >= 0 ? 1 : -1;

            while (x != 0)
            {
                int newDigit = Math.Abs(x % 10);
                int tempAns = ans * 10 + newDigit;
                //My solution
                //if ((baseNum == 9 && newDigit > 7) || (ans > int.MaxValue / 10 || ans * sign < int.MinValue / 10)) return 0;

                //After looking up and seeing how to check overflow 
                //I wouldn't need to keep track of base num thi
                if ((tempAns - newDigit) / 10 != ans) return 0;

                ans = ans * 10 + newDigit;
                baseNum += 1;
                x /= 10;
            }

            return ans * sign;
            #endregion
        }
    }
}
