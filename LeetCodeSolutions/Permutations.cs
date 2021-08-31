using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{
    public static class Permutations
    {
        public static IList<IList<int>> Solution (int[] nums)
        {
            if (nums.Length == 0) return null;
            IList<IList<int>> answer = new List<IList<int>>();
            if (nums.Length == 1)
            {
                var tempArr = new List<int>();
                tempArr.Add(nums[0]);
                answer.Add(tempArr);
                return answer;
            }
            foreach (int n in nums)
            {
                IList<int> initArr = new List<int> { n };
                Recursive(initArr, nums.Where(x => x != n).ToArray(), ref answer);
            }

            return answer;
        }

        private static void Recursive(IList<int> initArr, int[] nums, ref IList<IList<int>> answer)
        {

            if (nums.Length == 1)
            {
                initArr.Add(nums[0]);
                answer.Add(initArr);
                return;
            }
            foreach (int n in nums)
            {
                IList<int> tempArr = new List<int>(initArr);
                tempArr.Add(n);
                Recursive(tempArr, nums.Where(x => x != n).ToArray(), ref answer);
            }

        }
    }
}
