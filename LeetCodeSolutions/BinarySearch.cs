using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class BinarySerach
    {
        //Using Iteration
        public static int Solution(int[] nums, int target) 
        {
            int start = 0;
            int end = nums.Length - 1;
        
            while (start <= end)
            {
                int mid  = (end + start) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }
                if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else 
                {
                    start = mid + 1;
                }
            }
            return -1;
        }
    }
}