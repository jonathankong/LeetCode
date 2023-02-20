using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    public static class ThreeSum
    {
        public static IList<IList<int>> Solution(int[] nums)
        {   
            #region First Answer
            // IList<IList<int>> answers = new List<IList<int>>();
            // Dictionary<Tuple<int, int>, int> memo = new Dictionary<Tuple<int, int>, int>();
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     for (int j = i + 1; j < nums.Length; j++)
            //     {
            //         if (memo.ContainsKey(new Tuple<int, int>(nums[i], nums[j]))) continue;
            //         int target = -1 * (nums[i] + nums[j]);
            //         for (int k = j + 1; k < nums.Length; k++)
            //         {
            //             if (nums[k] == target) 
            //             {
            //                 memo.TryAdd(new Tuple<int, int>(nums[i], nums[j]), 0);
            //                 memo.TryAdd(new Tuple<int, int>(nums[i], nums[k]), 0);
            //                 memo.TryAdd(new Tuple<int, int>(nums[j], nums[i]), 0);
            //                 memo.TryAdd(new Tuple<int, int>(nums[j], nums[k]), 0);
            //                 memo.TryAdd(new Tuple<int, int>(nums[k], nums[i]), 0);
            //                 memo.TryAdd(new Tuple<int, int>(nums[k], nums[j]), 0);
            //                 answers.Add(new List<int>{nums[i], nums[j], nums[k]});
            //                 break;
            //             }
            //         }
            //     }
            // }
            // return answers;
            #endregion
            #region Second Answer
                IList<IList<int>> answers = new List<IList<int>>();
                Dictionary<Tuple<int, int, int>, int> memoAnswers = new Dictionary<Tuple<int, int, int>, int>();

                //Sort Array first
                Array.Sort(nums);

                //Go through each value in sorted array
                for (int ind = 0; ind < nums.Length; ind++)
                {
                    //See if it's a duplicate
                    if (nums[ind] == nums[ind] - 1) continue;
                    //Create 2 pointers
                    int left = ind + 1;
                    int right = nums.Length - 1;

                    while (left < right)
                    {
                        int target = nums[ind] + nums[left] + nums[right];
                        //Target value is too small
                        if (target < 0) left++;
                        //Target value is too larger
                        else if (target > 0) right--;
                        else
                        {
                            //Check if answer has already been encountered
                            if (!memoAnswers.ContainsKey(new Tuple<int, int, int>(nums[ind], nums[left], nums[right])))
                            {
                                //Add unique answer and memoize it
                                answers.Add(new int[]{nums[ind], nums[left], nums[right]});
                                memoAnswers.TryAdd(new Tuple<int, int, int>(nums[ind], nums[left], nums[right]), 0);
                            }
                            //Continue testing with nums[ind] in case there are unique answers
                            left++;
                            right--;
                        } 
                    }
                }
                return answers;
            #endregion
        }
    }
}
