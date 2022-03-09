using System;

namespace LeetCodeSolutions
{
    public static class FindMaxArea
    {
        public static int Solution(int[][] grid)
        {
            int maxArea = 0;
            
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        maxArea = Math.Max(maxArea, FMA(ref grid, i, j));
                    }
                }
            }
            return maxArea;
        }
        
        private static int FMA(ref int[][] grid, int r, int c)
        {
            if (r >= 0 && r < grid.Length && c >= 0 && c < grid[0].Length && grid[r][c] == 1)
            {
                grid[r][c] = 0;
                return 1 + FMA(ref grid, r - 1, c) + 
                    FMA(ref grid, r + 1, c) + 
                    FMA(ref grid, r, c - 1) + 
                    FMA(ref grid, r, c + 1);
            }
            return 0;
        }
    }
}