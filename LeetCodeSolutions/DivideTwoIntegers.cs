using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{ 
    public static class DivideTwoIntegers
    {
        public static int Solution(int dividend, int divisor)
        {
            //0 divided by anything
            if (dividend == 0) return 0;

            //dividing by same number
            if (dividend == divisor) return 1;

            bool negDividend = dividend < 0;
            bool negDivisor = divisor < 0;

            //Dividing by -1
            if (divisor == -1)
            {
                //Check to see if dividend is the min value because when made positive
                //It'll go over int.MaxValue
                if (dividend == int.MinValue) return int.MaxValue;
                else return dividend - dividend - dividend;
            }
            else if (divisor == 1) return dividend;
    
            int numOfSubtractions = 0;

            if (negDivisor == negDividend)
            {
                //If non negative values
                if (!negDivisor)
                {
                    while (dividend - divisor >= 0)
                    {
                        dividend -= divisor;
                        numOfSubtractions++;
                    }
                }
                else 
                {
                    while (dividend - divisor <= 0)
                    {
                        dividend -= divisor;
                        numOfSubtractions++;
                    }
                }
            }
            else if (negDividend)
            {
                while (dividend + divisor <= 0)
                {
                    dividend += divisor;
                    numOfSubtractions--;
                }
            }
            else 
            {
                while (dividend + divisor >= 0)
                {
                    dividend += divisor;
                    numOfSubtractions--;
                }
            }
        
            return numOfSubtractions;
        }     
    }
}
