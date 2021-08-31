using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    //Recursion Exercises from https://tildesites.bowdoin.edu/~ltoma/teaching/cs107/spring05/recursion.html
    
    //Sum all numbers from n to 0
    static class RecursionExercise1
    {
        public static int Solution(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                return num + Solution(num - 1);
            }
        }
    }
}
