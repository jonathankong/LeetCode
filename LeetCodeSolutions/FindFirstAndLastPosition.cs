using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class FindFirstAndLastPosition
    {
        private static int[] targetNotFound = new int[]
        {
            -1, -1
        };
        public static int[] Solution(int[] nums, int target)
        {
            return Recursion(nums, 0, nums.Length - 1, target);
        }

        private static int[] Recursion(int[] nums, int left, int right, int target)
        {
            if (left > right) return targetNotFound;

            var mid = (left + right) / 2;
            if (target == nums[mid])
            {
                left = mid;
                right = mid;

                while (left >= 0 && right <= nums.Length - 1 && (nums[left] == target || nums[right] == target))
                {
                    if (nums[left] == target)
                    {
                        left--;
                    }
                    if (nums[right] == target)
                    {
                        right++;
                    }
                }
                return new int[] { left == 0 ? left : left + 1, right == nums.Length - 1 ? right : right - 1};
            }
            else if (target < nums[mid])
            {
                return Recursion(nums, left, mid - 1, target);
            }
            else
            {
                return Recursion(nums, mid + 1, right, target);
            }
        }
    }
}