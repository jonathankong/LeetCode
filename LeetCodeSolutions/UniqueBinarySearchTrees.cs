using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class UniqueBinarySearchTrees
    {
        //Dictionary<int, int> memo = new Dictionary<int, int>();

        //public int NumTrees(int n)
        //{

        //    memo.Add(0, 1);
        //    memo.Add(1, 1);
        //    memo.Add(2, 2);

        //    Recursion(n);

        //    return memo[n];
        //}

        //private void Recursion(int n)
        //{
        //    int answer = 0;
        //    //Only need to calculate half of the possible BSTs because the other half are just mirror images.

        //    //Loop chooses a root, then we calculate how many choices you have for the left and right nodes.  From there, see if the options exist in memory.  If not, recursively determine the number of unique BSTs when there are 3 or more options.
        //    //This breaks down the problem into sub problems.
        //    for (int i = 1; i <= n / 2 + (n % 2 == 0 ? 0 : 1); i++)
        //    {
        //        int rightSideOptions = n - i;
        //        int leftSideOptions = n - rightSideOptions - 1;

        //        if (!memo.ContainsKey(rightSideOptions)) Recursion(rightSideOptions);

        //        if (!memo.ContainsKey(leftSideOptions)) Recursion(leftSideOptions);

        //        answer += memo[rightSideOptions] * memo[leftSideOptions] * (rightSideOptions == leftSideOptions ? 1 : 2);
        //    }

        //    if (!memo.ContainsKey(n)) memo.Add(n, answer);
        //}
    }
}
