using System;

namespace LeetCodeSolutions
{
    public static class LongestConsecutive
    {
        public static int Solution(int[] nums)
        {
            //First Answer
            //Sort the array and then find the longest consecutive element sequence
            if (nums.Length == 0) return 0;

            Array.Sort(nums);

            var maxAnswer = 0;
            var currAnswer = 1;    
            var lastNum = nums[0];        
            for (int i = 1; i < nums.Length; i++)
            {
                //Don't break the current streak if duplicates are encountered in Nums
                if (lastNum != nums[i])
                {
                    if (lastNum + 1 == nums[i]) // || lastNum == nums[i]) 
                        currAnswer++;
                    else 
                    {
                        if (currAnswer > maxAnswer) maxAnswer = currAnswer;
                        currAnswer = 1;  
                    }

                    lastNum = nums[i];  
                }
            }

            return maxAnswer > currAnswer ? maxAnswer : currAnswer;
                
        }
    }
}