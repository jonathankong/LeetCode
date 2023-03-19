using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{ 
    public static class FindPivotIndex
    {
        public static int Solution(int[] nums)
        {
            //Used 2 pointers and nested loops
            #region First Solution
            int left = 0;
            int right = nums.Length - 1;
            int leftSum = 0;

            for (left = 0; left < nums.Length; left++)
            {
                leftSum += nums[left];
                int rightSum = 0;
                for (right = nums.Length - 1; right >= left; right--)
                {
                    rightSum += nums[right];
                    if (right == left && rightSum == leftSum) return left;
                }
            }

            return -1;
            #endregion
        }     
    }
}
