using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class MergeSortedArray
    {
        public static int[] Solution(int[] nums1, int m, int[] nums2, int n)
        {
            //half of merge Sort
            //Using a queue to store values from nums1 if they are being overwritten
            
            int pointer2 = 0;
            Queue<int> nums1Vals = new Queue<int>();
            
            for (int i = 0; i < nums1.Length; i++)
            {
                //If at the end of nums1 value length
                if (i >= m)
                {
                    //No values in queue means there are only nums2's values to insert into nums1
                    if (nums1Vals.Count == 0)
                    {
                        nums1[i] = nums2[pointer2];
                        pointer2++;
                    }
                    else 
                    {
                        //Check nums2's values to queue's values
                        if (pointer2 >= n || nums1Vals.Peek() < nums2[pointer2])
                        {
                            nums1[i] = nums1Vals.Dequeue();
                        }
                        else {
                            nums1[i] = nums2[pointer2];
                            pointer2++;
                        }
                    }
                }
                //If still within nums1's values
                else 
                {
                    if (nums1Vals.Count == 0)
                    {   
                        //Only need to check this because the opposite is just nums1[i] = nums1[i];
                        if (pointer2 < n && nums1[i] >= nums2[pointer2])
                        {
                            nums1Vals.Enqueue(nums1[i]);
                            nums1[i] = nums2[pointer2];
                            pointer2++;
                        }
                    }
                    else 
                    {
                        //This means we're adding numbers to num1 and overriding its existing values
                        nums1Vals.Enqueue(nums1[i]);
                        //Check nums2's values to queue's values
                        if (pointer2 >= n || nums1Vals.Peek() < nums2[pointer2])
                        {
                            
                            nums1[i] = nums1Vals.Dequeue();
                        }
                        else
                        {
                            nums1[i] = nums2[pointer2];
                            pointer2++;
                        }
                    }
                }
            }
            return nums1;
        }
    }
}