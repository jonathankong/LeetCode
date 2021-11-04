using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class MinimumPathSum
    {
        //Using Bottom Up approach
        static public int Solution(int[][] grid)
        {
            return Recursion(grid, grid.Length - 1, grid[0].Length - 1);
        }

        static private int Recursion(int[][] grid, int startX, int startY)
        {
            if (startX == 0 && startY == 0)
            {
                return grid[startX][startY];
            }
            else if (startX < 0 || startY < 0)
            {
                return 0;
            }

            int startXminus1 = startX == 0 ? startX : startX - 1;
            int startYminus1 = startY == 0 ? startY : startY - 1;
            //Compare Left vs Up option
            //If left is bigger than up, go up
            if (grid[startX][startYminus1] > grid[startXminus1][startY])
            {
                //If at top most of array, must go left
                if (startX == 0)
                {
                    return grid[startX][startY] + Recursion(grid, startX, startYminus1);
                }
                return grid[startX][startY] + Recursion(grid, startXminus1, startY);
            }
            else if (grid[startX][startYminus1] < grid[startXminus1][startY])
            {
                //If at left most of array, must go up
                if (startY == 0)
                {
                    return grid[startX][startY] + Recursion(grid, startXminus1, startY);
                }
                return grid[startX][startY] + Recursion(grid, startX, startYminus1);
            }
            //If equal
            else
            {
                return 
            }
        }
    }
}
