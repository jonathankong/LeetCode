using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class SearchRotatedSortedArray
    {
        #region First Solution
        //public static int Solution (int[] nums, int target)
        //{
        //    if (nums[0] <= target)
        //    {
        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            if (nums[i] == target)
        //            {
        //                return i;
        //            }
        //            else if (i + 1 < nums.Length && nums[i] > nums[i + 1])
        //            {
        //                return -1;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = nums.Length - 1; i >= 0; i--)
        //        {
        //            if (nums[i] == target)
        //            {
        //                return i;
        //            }
        //            else if (i - 1 >= 0 && nums[i] < nums[i - 1])
        //            {
        //                return -1;
        //            }
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region Second Solution using Binary Search methodology
        //public static int Solution (int[] nums, int target)
        //{
        //    int l = 0;
        //    int r = nums.Length - 1;

        //    while (l <= r)
        //    {
        //        var mid = (l + r) / 2;

                
        //    }
        //}
        #endregion
    }
}
