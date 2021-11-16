using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    public static class Subsets
    {
        public static IList<IList<int>> Solution(int[] nums)
        {
            var answersList = new List<IList<int>>();
            answersList.Add(new List<int>());

            //Grab each element of the array
            for(int i = 0; i < nums.Length; i++)
            {
                answersList.Add(new List<int>(nums[i]));
                for (int j = 1; j < nums.Length - i; j++)
                {
                    
                }
            }
            return answersList;
        }
    }
}
