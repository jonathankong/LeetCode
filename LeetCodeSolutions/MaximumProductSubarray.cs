using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    class MaximumProductSubarray
    {
        //public int Solution(int[] nums)
        //{
        //    if (nums.Length == 1) return nums[0];

        //    int currMaxProduct = 1;
        //    int currMinProduct = 1;
        //    int answer = nums[0];

        //    //Calculate the min and max based on each element and its previous min and max subarray products.
        //    //Then see if it is larger or smaller than the current max and current min, respectively.
        //    //Then remember the currentMax as that current max can change if it encounters negative values or zero.
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int curr = nums[i];
        //        int tempMaxProduct = nums[i] * currMaxProduct;
        //        int tempMinProduct = nums[i] * currMinProduct;

        //        currMaxProduct = Math.Max(curr, Math.Max(tempMaxProduct, tempMinProduct));
        //        currMinProduct = Math.Min(curr, Math.Min(tempMaxProduct, tempMinProduct));

        //        answer = Math.Max(answer, currMaxProduct);
        //    }

        //    return answer;
        //}
    }
}
