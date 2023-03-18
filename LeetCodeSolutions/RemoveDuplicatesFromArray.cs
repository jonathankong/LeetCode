using System;

namespace LeetCodeSolutions
{
    public static class RemoveDuplicatesFromArray
    {
        public static int Solution(int[] nums)
        {
            #region First Answer
            // int currVal = nums[0];
            // int swapIndex = 0;
            // int numOfDuplicates = 0;
            
            // for (int counter = 1; counter < nums.Length; counter++)
            // {
            //     if (nums[counter] == currVal) 
            //     {
            //         if (swapIndex == 0) swapIndex = counter;
            //         numOfDuplicates++;
            //     }
            //     else 
            //     {
            //         currVal = nums[counter];
            //         nums[swapIndex] = currVal;
            //         swapIndex++;
            //     }
            // }
            // return numOfDuplicates;
            #endregion
            #region Second Answer
            int currNum = nums[0];
            int answer = 1;
            int counter = 1;
            while (counter < nums.Length)
            {
                if (currNum == nums[counter]) nums[counter] = 101;
                else if(currNum < nums[counter])
                {
                    currNum = nums[counter];
                    answer++;
                }
                counter++;
            }
            Array.Sort(nums);
            return answer;
            #endregion
        }
    }
}