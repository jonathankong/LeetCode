using System;

namespace LeetCodeSolutions
{
    public static class MaximumSubarray
    {
        public static int Solution(int[] nums)
        {
            int maxSum = nums[0];
            int currSum = nums[0];
            
            for (int left = 1; left < nums.Length; left++)
            {
                //Reset sums if the current value in nums is bigger than a negative maxSum
                if (nums[left] > maxSum && maxSum < 0)
                {
                    maxSum = nums[left];
                    currSum = nums[left];
                }
                //Reset current sum if the nearly added number makes the sum negative
                else if (currSum + nums[left] < 0)
                {
                    currSum = 0;
                }
                //Add value to current sum and compare it to maxSum
                else 
                {
                    currSum += nums[left];
                    maxSum = Math.Max(currSum, maxSum);
                }
            }
            return maxSum;
        }
    }
}