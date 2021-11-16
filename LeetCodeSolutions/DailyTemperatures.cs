using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class DailyTemperatures
    {
        public static int[] Solution(int[] temperatures)
        {
            #region First Solution (O(n^2))
            //var ans = new int[temperatures.Length];
            //for (int i = temperatures.Length - 2; i >= 0; i--)
            //{
            //    for (int j = i + 1; j < temperatures.Length; j++)
            //    {
            //        if (temperatures[i] < temperatures[j])
            //        {
            //            ans[i] = j - i;
            //            break;
            //        }
            //    }
            //}
            //return ans;
            #endregion

            #region Second Solution (Using stack going from Left to Right O(n*m))
            var ans = new int[temperatures.Length];
            //Use stack to keep track of consecutively smaller temperatures and their
            //positions in array until encountering a larger one
            var stack = new Stack<int[]>();
            var counter = 0;
            while (counter < temperatures.Length)
            {
                if (stack.Count != 0 && stack.Peek()[0] < temperatures[counter])
                {
                    //Once encounter a larger temp, compare all temps in stack to the larger temp
                    //and save position difference into answer array
                    while (stack.Count != 0 && stack.Peek()[0] < temperatures[counter])
                    {
                        ans[stack.Peek()[1]] = counter - stack.Peek()[1];
                        stack.Pop();
                    }
                }
                stack.Push(new int[] { temperatures[counter], counter });
                counter++;
            }
            //Any temps with no larger temp after it will default have a 0 value in answer array
            return ans;
            #endregion
        }
    }
}
