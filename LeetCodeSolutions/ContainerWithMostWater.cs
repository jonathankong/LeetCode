using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class ContainerWithMostWater
    {
        public static int Solution(int[] height)
        {
            int start = 0;
            int end = height.Length - 1;

            int maxArea = 0;

            while (start < end)
            {
                //get length and width of water container
                int x = end - start;
                int y = Math.Min(height[start], height[end]);
                int area = x * y;

                //Remember largest area
                if (area > maxArea) maxArea = area;

                //Decide which pointer to move towards the other
                if (height[start] > height[end]) end -= 1;
                else start += 1;
            }

            return maxArea;
        }
    }
}
