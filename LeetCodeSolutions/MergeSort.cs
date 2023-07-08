using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{
    static class MergeSort
    {
        public static int[] Solution(int[] arr)
        {
            if (arr.Length == 1) return arr;
            int mid = arr.Length / 2;
            int[] arrLeft = Solution(arr.Take(mid).ToArray());
            int[] arrRight = Solution(arr.Skip(mid).Take(arr.Length - mid).ToArray());

            int leftInd = 0;
            int rightInd = 0;
            int newArrInd = 0;
            
            int[] newArr = new int[arrLeft.Length + arrRight.Length];

            while (leftInd < arrLeft.Length || rightInd < arrRight.Length)
            {
                if (leftInd == arrLeft.Length)
                {
                    AppendFromRightArr(arrRight, newArr, ref rightInd, ref newArrInd);
                }
                else if (rightInd == arrRight.Length)
                {
                    AppendFromLeftArr(arrLeft, newArr, ref leftInd, ref newArrInd);
                }
                else 
                {
                    if (arrLeft[leftInd] > arrRight[rightInd])
                    {
                        AppendFromRightArr(arrRight, newArr, ref rightInd, ref newArrInd);
                    }
                    else 
                    {
                        AppendFromLeftArr(arrLeft, newArr, ref leftInd, ref newArrInd);
                    }
                }
            }

            return newArr;
        }

        private static void AppendFromLeftArr(int[] arrLeft, int[] newArr, 
            ref int leftInd, ref int newArrInd)
        {
            newArr[newArrInd] = arrLeft[leftInd];
            newArrInd++;
            leftInd++;
        }
        private static void AppendFromRightArr(int[] arrRight, int[] newArr, 
            ref int rightInd, ref int newArrInd)
        {
            newArr[newArrInd] = arrRight[rightInd];
            newArrInd++;
            rightInd++;
        }
    }
}
