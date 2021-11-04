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
            for (int i = grid.Length - 1; i >= 0; i--)
            {
                for (int j = grid[0].Length - 1; j >= 0; j--)
                {
                    //Add minimum of bottom or right of cell to cell
                    //Checks for out of bounds
                    if (i + 1 == grid.Length && j + 1 == grid[0].Length)
                    {
                        continue;
                    }
                    else if (i + 1 == grid.Length)
                    {
                        grid[i][j] += grid[i][j + 1];
                    }
                    else if (j + 1 == grid[0].Length)
                    {
                        grid[i][j] += grid[i + 1][j];
                    }
                    else
                    {
                        grid[i][j] += Math.Min(grid[i + 1][j], grid[i][j + 1]);
                    }
                }
            }
            return grid[0][0];
        }
    }
}
