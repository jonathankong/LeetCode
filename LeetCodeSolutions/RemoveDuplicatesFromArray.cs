using System;

namespace LeetCodeSolutions
{
    public static class RemoveDuplicatesFromArray
    {
        public static int Solution(int[] nums)
        {

            //Updated first solution using 2 pointers: 
            //One keeps track of unique numbers
            //One iterates to find duplicates
            //O(n) faster than second solution because no sorting but mem usage
            // because of swapping 
            #region First Answer
            if (nums.Length == 1) return 1;

            int currNumIndx = 0;
            int duplNumIndx = 1;
            int ignoreNum = 101;

            while (duplNumIndx < nums.Length)
            {
                if (nums[currNumIndx] == nums[duplNumIndx])
                {
                    nums[duplNumIndx] = ignoreNum;
                }
                else if (currNumIndx - duplNumIndx == 1)
                {
                    currNumIndx++;
                }
                else
                {
                    currNumIndx++;
                    int tempNum = nums[duplNumIndx];
                    nums[duplNumIndx] = nums[currNumIndx];
                    nums[currNumIndx] = tempNum;
                }
                duplNumIndx++;
            }
            return currNumIndx + 1;
            #endregion
            
            //Iterate through array and change duplicates to large number
            //Afterwards, sort array so duplicates go to the end
            //O(n * nlogn)
            #region Second Answer
            // int currNum = nums[0];
            // int answer = 1;
            // int counter = 1;
            // while (counter < nums.Length)
            // {
            //     if (currNum == nums[counter]) nums[counter] = 101;
            //     else if(currNum < nums[counter])
            //     {
            //         currNum = nums[counter];
            //         answer++;
            //     }
            //     counter++;
            // }
            // Array.Sort(nums);
            // return answer;
            #endregion
        }
    }
}