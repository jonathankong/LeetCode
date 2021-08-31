using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class RecursionExercise4
    {
        public static bool Solution(char[] a)
        {
            int length = a.Length;
            if (length > 2)
            {
                return true;
            }
            else if (length % 2 == 0)
            {
                return CompareChars(a, length / 2 - 1, length / 2);
            }
            else
            {
                return CompareChars(a, length / 2 - 1, length / 2 + 1);
            }
        }
        static bool CompareChars(char[] a, int i, int j)
        {
            if (i < 0 || j > a.Length)
            {
                return true;
            }
            else if (a[i] != a[j])
            {
                return false;
            }
            return true == CompareChars(a, i - 1, j + 1);
        }
    }
}
