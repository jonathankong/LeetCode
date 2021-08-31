using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class ContatenationOfArray
    {
        //First Solution

        static int[] Solution(int[] nums)
        {
            List<int> ans = new List<int>();
            for (int counter = 1; counter <= 2; counter++)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    ans.Add(nums[i]);
                }
            }
            return ans.ToArray();
        }

        //Second Solution

        //static int[] Solution(int[] nums)
        //{
        //    List<int> ans = new List<int>(nums);

        //    ans.AddRange(nums);

        //    return ans.ToArray();
        //}
    }
}
