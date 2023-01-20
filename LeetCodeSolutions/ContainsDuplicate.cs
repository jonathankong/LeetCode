using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class ContainsDuplicate
    {
        public static bool Solution(int[] nums)
        {
            //initial answer
            // Array.Sort(nums);
            // int currentNum = nums[0];
            // for (int i = 1; i < nums.Length; i++)
            // {
            //     if (nums[i] == currentNum)
            //     {
            //         return true;
            //     }
            //     else
            //     {
            //         currentNum = nums[i];
            //     }
            // }
            // return false;

            //second answer
            HashSet<int> numbers = new HashSet<int>(nums);
            return numbers.Count != nums.Length;
        }
    }
}