using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class ProductArrayExceptSelf
    {
        public static int[] Solution(int[] nums)
        {
            #region First Answer
            //First answer uses memoization to cut down on calculations but is not O(1) space

            // //This will keep track of nums with their corresponding results
            // //if the num appears again, the answer has already been calculated so use that
            // Dictionary<int, int> memo = new Dictionary<int, int>();

            // int[] answer = new int[nums.Length];
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     int tempAnswer = 1;
            //     //Check if calculated answer already exists for this particular number
            //     if (!memo.TryAdd(nums[i], 1)) tempAnswer = memo[nums[i]];
            //     else
            //     {
            //         //Calculate product excluding self
            //         //Could probably search to see if there's a 0 in the array first
            //         //that way, all answers except the calculation where the self is 0 will equal 0
            //         for (int j = 0; j < nums.Length; j++)
            //         {
            //             if (j != i) tempAnswer *= nums[j];
            //             if (tempAnswer == 0) break;
            //         }
            //         memo[nums[i]] = tempAnswer;
            //     }
                
            //     answer[i] = tempAnswer;
            // }
            // return answer;
            #endregion

            #region Second Answer
            //Second answer trying to stay in O(1) space

            //If splitting up the product of the array, as progress through array, the left side product increases while the right one decreases. This means that we can keep track of the left product and multiply it by the left number of the current num and just recalculate the remaining right portion of array
            // int[] answer = new int[nums.Length];

            // int leftProduct = 1;
            // for (int i = 0; i < nums.Length; i++)
            // {
                
            //     //Calculate right product of current num
            //     int rightProduct = 1;
            //     for (int j = i + 1; j < nums.Length; j++)
            //     {
            //         rightProduct *= nums[j];
            //         if (rightProduct == 0) break;
            //     }

            //     //Calculate left product of current num and then save answer
            //     if (i == 0) answer[i] = rightProduct;
            //     else
            //     {
            //         leftProduct *= nums[i - 1];
            //         answer[i] = leftProduct * rightProduct;
            //     }

            // }
            // return answer;
            #endregion

            #region Third Answer
            //Third answer, after reviewing some other answers, it made me realize that the 2 loops do not have to be nested.  Store left product in answer array and then multiply it with right product in second loop

            int[] answer = new int[nums.Length];

            int leftProduct = 1;
            for (int i = 0; i < nums.Length; i++)
            {     
                if (i == 0) answer[i] = leftProduct; 
                else 
                {
                    leftProduct *= nums[i - 1];
                    answer[i] = leftProduct;
                }
            }

            //Calculate right product of current num and add it to the answer by traversing through the array from right to left
            int rightProduct = 1;
            for (int j = nums.Length - 2; j >= 0; j--)
            {
                rightProduct *= nums[j + 1];
                answer[j] *= rightProduct;
            }
            return answer;
            #endregion
        }
    }
}