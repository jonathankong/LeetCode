using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    public static class TopKFrequentElements
    {
        public static int[] Solution(int[] nums, int k)
        {
            Dictionary<int, int> numFreqDict = new Dictionary<int, int>();
            var answers = new List<int>();

            //Keep track of frequency using dictionary
            foreach (int num in nums)
            {
                if (!numFreqDict.TryAdd(num, 1))
                    numFreqDict[num]++;
            }

            //Now we have a dictionary that the key as the number from array and the value as how frequently it shows up.
            //We will now reverse the keyvalue pair mapping so that we have frequency as the key and a list of numbers that meet that frequency
            Dictionary<int, IList<int>> freqNumDict = new Dictionary<int, IList<int>>(); 
            foreach (var kvp in numFreqDict)
            {
                if (!freqNumDict.TryAdd(kvp.Value, new List<int>{kvp.Key})) 
                    freqNumDict[kvp.Value].Add(kvp.Key);
            }

            //Sort frequency disctionary by desc and save all values (nums) in answer list
            foreach (var kvp in freqNumDict.OrderByDescending(x => x.Key))
            {
                answers.AddRange(kvp.Value);
            }

            //Return first k portion of answer list
            return answers.Take(k).ToArray();
        }
    }
}
