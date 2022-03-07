using System;

namespace LeetCodeSolutions
{
    public static class MoveZeroes
    {
        #region First Solution
        // public static int[] Solution(int[] nums)
        // {
        //     int lastZeroPlacement = nums.Length - 1;
        //     int counter = 0;
            
        //     while (counter < lastZeroPlacement)
        //     {
        //         if (nums[counter] == 0)
        //         {
        //             Swap(nums, counter, lastZeroPlacement);
        //             lastZeroPlacement -= 1;
        //         }
        //         else
        //         {
        //             counter++;
        //         }
        //     }
            
        //     return nums;
        // }
        
        // private static void Swap(int[] nums, int start, int end)
        // {
        //     for (int i = start; i < end; i++)
        //     {
        //         int temp = nums[i + 1];
        //         nums[i + 1] = nums[i];
        //         nums[i] = temp;
        //     }
        // }
        #endregion
    }
}