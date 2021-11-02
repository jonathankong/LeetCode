using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class RotateImage
    {
        public static int[][] Solution(int[][] matrix)
        {
            Recursion(matrix, 0);
            return matrix;
        }

        private static void Recursion(int[][] matrix, int level)
        {
            if (level > matrix.Length / 2 - 1) return;
            var start = level;
            var end = matrix.Length - 1 - level;

            for (int i = 0; i < matrix.Length - 1 - (2 * level); i++)
            {
                //Save value from Right Side.
                var temp = matrix[end - i][end];
                //Move value from Top Row to Right Side
                matrix[end - i][end] = matrix[start][end - i];
                //Move value from Left Side to Top Row
                matrix[start][end - i] = matrix[start + i][start];
                //Move value from Bottom Row to Left Side
                matrix[start + i][start] = matrix[end][start + i];
                //Take saved value and put it into Bottom Row
                matrix[end][start + i] = temp;
            }

            Recursion(matrix, level + 1);
        }
    }
}
