using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{
    //Recursion Exercises from https://tildesites.bowdoin.edu/~ltoma/teaching/cs107/spring05/recursion.html
    
    //Sum numbers in array
    static class RecursionExercise3
    {
        public static int Solution(int[] a)
        {
            if (a.Length == 1)
            {
                return a[0];
            }
            else
            {
                return a[0] + Solution(a.Where(x => x != a[0]).ToArray());
            }
        }
    }
}
