using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{ 
    public static class RunningSum1DArray
    {
        public static int[] Solution(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0) nums[i] += nums[i - 1];
            }

            return nums;
        }     
    }
}
