using System;

namespace LeetCodeSolutions
{
    public static class RemoveDuplicatesFromArray
    {
        public static int Solution(int[] nums)
        {
            int currVal = nums[0];
            int swapIndex = 0;
            int numOfDuplicates = 0;
            
            for (int counter = 1; counter < nums.Length; counter++)
            {
                if (nums[counter] == currVal) 
                {
                    if (swapIndex == 0) swapIndex = counter;
                    numOfDuplicates++;
                }
                else 
                {
                    currVal = nums[counter];
                    nums[swapIndex] = currVal;
                    swapIndex++;
                }
            }
            return numOfDuplicates;
        }
    }
}