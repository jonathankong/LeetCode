using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class SortColours
    {
        public static void Solution(int[] nums)
        {
            #region Original Solution
            //int start = 0;
            //int end = nums.Length - 1;
            //int checkPos = start + 1;

            //while (start < end)
            //{
            //    if (nums[start] == 0)
            //    {
            //        start += 1;
            //        checkPos += 1;
            //    }
            //    else if (nums[end] == 2)
            //    {
            //        end -= 1;
            //    }
            //    else if (nums[start] == 2)
            //    {
            //        Swap(ref nums, start, end);
            //        end -= 1;
            //    }
            //    else if (nums[end] == 0)
            //    {
            //        Swap(ref nums, start, end);
            //        start += 1;
            //        checkPos += 1;
            //    }
            //    else
            //    {
            //        if (nums[checkPos] == 0)
            //        {
            //            Swap(ref nums, start, checkPos);
            //            start += 1;
            //            checkPos += 1;
            //        }
            //        else if (nums[checkPos] == 2)
            //        {
            //            Swap(ref nums, checkPos, end);
            //            end -= 1;
            //        }
            //        else
            //        {
            //            checkPos += 1;
            //        }
            //    }
            //}
            #endregion

            #region DutchNationalFlagProblem
            int start = 0;
            int mid = 0;
            int end = nums.Length - 1;

            while (mid <= end)
            {
                switch(nums[mid])
                {
                    case 0:
                        Swap(ref nums, start, mid);
                        start += 1;
                        mid += 1;
                        break;
                    case 1:
                        mid += 1;
                        break; 
                    case 2:
                        Swap(ref nums, mid, end);
                        end -= 1;
                        break;
                }
            }
            
            #endregion
        }

        private static void Swap (ref int[] nums, int a, int b)
        {
            int temp = nums[b];
            nums[b] = nums[a];
            nums[a] = temp;
        }
    }
}
