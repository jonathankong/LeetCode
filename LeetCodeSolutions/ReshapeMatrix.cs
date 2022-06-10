using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class ReshapeMatrix
    {
        public static int[][] Solution (int[][] mat, int r, int c)
        {
            //If area of old array and new array aren't the same
            if (mat.Length * mat[0].Length != r * c) return mat;
                    
            //Use jagged array
            int[][] answers = new int[r][];
            //This will act as the row of the answer array
            int[] tempArray = new int[c];
            int row = 0;
            int col = 0;
            
            //For loops will traverse the old array and the variables will traverse the new array
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[0].Length; j++)
                {
                    tempArray[col] = mat[i][j];

                    //Save temporary answer array in new array and move to next row of answer array
                    if (col == c - 1)
                    {
                        answers[row] = tempArray;
                        tempArray = new int[c];
                        row += 1;
                        col = 0;
                    }
                    else
                    {
                        col += 1;    
                    }
                }
            }
            
            return answers;
        }
    }
}