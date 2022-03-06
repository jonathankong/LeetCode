using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class FirstBadVersion
    {

        // public static int Solution(int n) {
        //     int start = 1;
        //     int end = n;
            
        //     while (start < end)
        //     {
        //         //Only way to avoid int overflow
        //         int mid = start + (end - start) / 2;
                
        //         //See if mid value is a good version
        //         if (!IsBadVersion(mid))
        //         {
        //             //Check later value to see if it is a bad version
        //             if (IsBadVersion(mid + 1))
        //             {
        //                 return mid + 1;
        //             }
        //             //Move starting position to right side of array
        //             else 
        //             {
        //                 start = mid + 1;
        //             }
        //         }
        //         //Version is a bad version
        //         else
        //         {
        //             //Check if earlier version is the good version
        //             if (mid == 1 || !IsBadVersion(mid - 1))
        //             {
        //                 return mid;
        //             }
        //             //Move end position to left side of array
        //             else 
        //             {
        //                 end = mid - 1;
        //             }
        //         }
        //     }
        //     return end;
        // }
    }
}