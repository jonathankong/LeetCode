using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    static class JumpGame2
    {
        public static int Solution(int[] nums)
        {
            if (nums.Length == 1 && nums[0] == 0) return 0;
            else if (nums.Length == 1 && nums[0] != 0 && nums.Length == 2) return 1;
            else return Recursion(nums);
        }

        private static int Recursion(int[] nums)
        {
            if (nums.Length == 1) return 1;
            else if (nums.Length == 2) return 1;
            int value = -1;
            for (int i = nums.Length - 2; i >= 0; i--)
            { 
                if ((nums.Length - 1) - i <= nums[i])
                {
                    value = nums[i];
                }
            }
            return value == -1 ? 1 : 1 + Recursion(nums.Take(nums.Length - value).ToArray());
        }
    }
}
