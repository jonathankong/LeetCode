using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class MedianOfTwoSortedArrays
    {
        public static double Solution(int[] nums1, int[] nums2)
        {
            //If one of the arrays is empty, just find the median of the other
            if (nums1.Length == 0) return FindMedianInOneArray(nums2);
            else if (nums2.Length == 0) return FindMedianInOneArray(nums1);
            
            int i = 0;
            int j = 0;
            
            int totalLength = nums1.Length + nums2.Length;

            Stack<int> mergedArray = new Stack<int>();
            
            for (int totalCounter = 0; totalCounter < totalLength; totalCounter++)
            {
                if (j >= nums2.Length || i < nums1.Length && nums1[i] < nums2[j])
                {
                    mergedArray.Push(nums1[i]);
                    i++;
                }
                else if (i >= nums1.Length || j < nums2.Length && nums1[i] >= nums2[j]) 
                {
                    mergedArray.Push(nums2[j]);
                    j++;
                }
                
                //Median found
                if (mergedArray.Count == totalLength / 2 + 1) break;
            }
            
            //Median is 2 values
            if (totalLength % 2 == 0)
            {
                return (double)(mergedArray.Pop() + mergedArray.Pop()) / 2.0;
            }
            return mergedArray.Pop();
        }
        private static double FindMedianInOneArray(int[] nums)
        {
            //If array is even, there are 2 values that make up median
            if (nums.Length % 2 == 0)
            {
                return (double)(nums[nums.Length / 2] + nums[nums.Length / 2 - 1]) / 2.0;
            }
            //only 1 value is the median
            return nums[nums.Length / 2];

        }
    }
}