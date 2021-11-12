using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class ClimbingStairs
    {
        public static int Solution(int n)
        {
            var memo = new Dictionary<int, int>();

            return BottomUp(n);
        }

        private static int Recursion(int n, int start, Dictionary<int, int> memo)
        {
            if (start == n)
            {
                return 1;
            }
            else if (start > n)
            {
                return 0;
            }
            else if (memo.ContainsKey(start))
            {
                return memo[start];
            }

            int answer = Recursion(n, start + 1, memo) + Recursion(n, start + 2, memo);
            memo.Add(start, answer);

            return answer;
        }

        private static int BottomUp (int n)
        {
            if (n <= 1) return n;
            if (n == 2) return 2;
            if (n == 3) return 3;

            var memo = new int[n];
            memo[n - 1] = 1;
            memo[n - 2] = 2;

            for (int i = n - 3; i >= 0; i--)
            {
                memo[i] = memo[i + 1] + memo[i + 2];
            }

            return memo[0];
        }
    }
}
