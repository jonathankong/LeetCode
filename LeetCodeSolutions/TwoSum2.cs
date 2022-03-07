using System;

namespace LeetCodeSolutions
{
    public static class TwoSum2
    {
        public static int[] Solution(int[] numbers, int target)
        {
            #region First Solution (2 loops)
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     int complement = target - numbers[i];
                
            //     for (int j = i + 1; j < numbers.Length; j++)
            //     {
            //         if (numbers[j] == complement) return new int[] {i + 1, j + 1};
            //     }
            // }
            // return new int[2];
            #endregion
        
            #region Second Solution (1 loop)
                int left = 0;
                int right = numbers.Length - 1;

                while (left < right)
                {
                    int sum = numbers[left] + numbers[right];
                    if (sum == target) break;          
                    else if (sum < target) left += 1;
                    else right -= 1;
                }
                return new int[] {left + 1, right + 1};
            #endregion
        }
    }
}