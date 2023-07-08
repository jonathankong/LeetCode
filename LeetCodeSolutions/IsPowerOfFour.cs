using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{ 
    public static class IsPowerOfFour
    {
        public static bool Solution(int n)
        {
            if (n == 4 || n == -4 || n == 1 || n == -1) return true;
            if (n % 2 != 0 || (n > -16 && n < 16)) return false;
            return Solution((int) Math.Ceiling(Math.Abs((double) n / 4)));
        }
    }
}
