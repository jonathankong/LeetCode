using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class SearchIndexPosition
    {
        public static int Solution(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                
                if (nums[mid] == target) return mid;
                
                if (nums[mid] < target) start = mid + 1;
                else end = mid - 1;
            }
            
            return start;
        }
    }
}