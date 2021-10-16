using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class Test
    {
        public static int Solution(int steps)
        {
            int answer = 0;
            int step1 = 1;
            int step2 = 1;
            int step3 = 2;

            for (int i = 0; i < steps - 2; i++)
            {
                var temp1 = step1;
                var temp2 = step2;
                step1 = step2;
                step2 = step3;
                step3 = temp1 + temp2 + step2;
            }

            return step3;
        }
    }
}
