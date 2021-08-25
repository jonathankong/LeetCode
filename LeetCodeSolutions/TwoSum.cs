using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            #region MyFirstSolution
            //int firstNumIndex = 0;
            //int secondNumIndex = 0;
            //bool foundAnswer = false;
            //for (firstNumIndex = 0; firstNumIndex < nums.Length; firstNumIndex++)
            //{
            //    for (secondNumIndex = firstNumIndex + 1; secondNumIndex < nums.Length; secondNumIndex++)
            //    {
            //        if (nums[firstNumIndex] + nums[secondNumIndex] == target)
            //        {
            //            foundAnswer = true;
            //            break;
            //        }
            //        if (nums[secondNumIndex] > target)
            //        {
            //            continue;
            //        }
            //    }
            //    if (foundAnswer)
            //    {
            //        break;
            //    }
            //    if (nums[firstNumIndex] > target)
            //    {
            //        continue;
            //    }
            //}
            //return new int[] { firstNumIndex, secondNumIndex };
            #endregion
            #region Recusion
            return Recursion(nums, 0, 1, target);
            #endregion
            #region FindingComplements
            //Dictionary<int, int> complements = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (complements.TryGetValue(nums[i], out int value))
            //    {
            //        return new int[] { value, i };
            //    }
            //    complements.Add(target - nums[i], i);
            //}
            #endregion
        }

        //Recursive Solution
        private static int[] Recursion(int[] nums, int i, int j, int target)
        {
            if (j < nums.Length && i < nums.Length)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
                else if (j == nums.Length - 1)
                {
                    return Recursion(nums, i + 1, i + 2, target);
                }
                else
                {
                    return Recursion(nums, i, j + 1, target);
                }
            }
            return null;
        }
    }
}
