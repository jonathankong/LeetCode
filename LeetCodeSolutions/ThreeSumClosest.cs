using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{
    public static class ThreeSumClosest
    {
        public static string Solution(int[] nums, int target)
        {
            
            if (nums.Length == 3) return $"{nums.Sum()} 0 1 2";
        
            int indx1 = 0;
            int indx2 = 0;
            int indx3 = 0;
            int closestSum = int.MaxValue;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                
                while (left < right)
                {
                    int tempSum = nums[i] + nums[left] + nums[right];
                    int currentSumTargetDiff = Math.Abs(tempSum - target);
                    int closestSumTargetDiff = Math.Abs(closestSum - target);

                    if (currentSumTargetDiff < closestSumTargetDiff) closestSum = tempSum;

                    if (tempSum == target) return $"{target} {indx1} {indx2} {indx3}";
                    else if (tempSum < target) left++;
                    else right--;      
                }
            }
            return $"{closestSum} {indx1} {indx2} {indx3}";
        }     
    }
}
