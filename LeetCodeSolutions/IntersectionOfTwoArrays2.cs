using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class IntersectionOfTwoArrays2
    {
        public static int[] Solution(int[] nums1, int[] nums2)
        {
            //Keep track of values and occurances in the largest of the two arrays 
            Dictionary<int, int> largestArrVals = new Dictionary<int, int>();
            List<int> answers = new List<int>();

            int smallestLength = Math.Min(nums1.Length, nums2.Length);
            int[] largestArr = nums1.Length < nums2.Length ? nums2 : nums1;
            int[] smallestArr = nums1.Length < nums2.Length ? nums1 : nums2;

            //Add values and occurances of values into dictionary            
            for (int i = 0; i < largestArr.Length; i++)
            {
                if (!largestArrVals.ContainsKey(largestArr[i])) 
                    largestArrVals.Add(largestArr[i], 1);
                else 
                    largestArrVals[largestArr[i]]++;
            }
            
            //Iterate through smaller array and check the dictionary for each value
            //If it exists, decrement the occurence of the value and then add the value into the answers array
            for (int i = 0; i < smallestArr.Length; i++)
            {
                if (largestArrVals.ContainsKey(smallestArr[i]) && largestArrVals[smallestArr[i]] > 0) 
                {
                    answers.Add(smallestArr[i]);
                    largestArrVals[smallestArr[i]]--;
                }
            }
            
            return answers.ToArray();
        }
    }
}