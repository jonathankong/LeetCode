using System;

namespace LeetCodeSolutions
{
    public static class RemoveElement
    {
        public static int Solution(int[] nums, int val)
        {
            //Using 2 pointers to swap any numbers that equal value
            #region First Answer
            if (nums.Length == 0) return 0;
        
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (nums[left] == val)
                {
                    int temp = nums[right];
                    nums[right] = 51;
                    nums[left] = temp;
                    right--;
                }
                else 
                {
                    left++;
                }                
            }

            //Now review instance where left == right and nums[left] == val
            if (left == right)
            {
                if (nums[left] == val) nums[left] = 51;
                else left++;
            }
            
            return left;
            #endregion
        }
    }
}