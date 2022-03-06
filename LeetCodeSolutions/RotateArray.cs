using System;

namespace LeetCodeSolutions
{
    public static class RotateArray
    {
        public static int[] Solution(int[] nums, int k)
        {
            //Original answer.  This answer failed when the k value and the array were both even.

            // k =  k % nums.Length;
            // int toIndex = k;
            // int replaceVal = nums[0];
            // int tempVal = nums[toIndex];
            
            // for (int i = 0; i <= nums.Length; i++)
            // {
            //     nums[toIndex] = replaceVal;
            //     replaceVal = tempVal;
            //     toIndex = toIndex + k > nums.Length - 1 ? toIndex - nums.Length + k : toIndex + k;
            //     tempVal = nums[toIndex];
            // }
            // return nums;

            //After doing some research, this answer is the proper one.
            //First reverse first half of array (0 to nums.Length - 1 - k)
            //Reverse second half (nums.Length - k to nums.Length - 1)
            //Then reverse entire array.

            k = k % nums.Length;
            if (k == 0) return nums;
            ReverseArr(nums, 0, nums.Length - 1 - k);
            ReverseArr(nums, nums.Length - k, nums.Length - 1);
            ReverseArr(nums, 0, nums.Length - 1);
            return nums;
        }
        
        private static void ReverseArr(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[end];
                nums[end] = nums[start];
                nums[start] = temp;
                
                start += 1;
                end -= 1;
            }
        }
    }
}