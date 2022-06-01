using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class IsValidSudoku
    {
        public static bool Solution(char[][] board)
        {
            //Use two loops to check both rows and columns at the same time
            //This is done by using one loop as traversing 1 of the 9 rows/cols and the nested loop to
            //traverse through that array
            
            int topLeftSubBoxRowIndex = 0;
            int topLeftSubBoxColIndex = 0;
            
            for (int i = 0; i < board.Length; i++)
            {
                Dictionary<int, int> uniqueRowValues = new Dictionary<int, int>();
                Dictionary<int, int> uniqueColValues = new Dictionary<int, int>();
                Dictionary<int, int> uniqueSubBoxValues = new Dictionary<int, int>();
          
                int startRowIndex = topLeftSubBoxRowIndex;
                int startColIndex = topLeftSubBoxColIndex;
                
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (uniqueRowValues.ContainsKey(board[i][j]) || uniqueColValues.ContainsKey(board[j][i])
                    || uniqueSubBoxValues.ContainsKey(board[startRowIndex][startColIndex]))
                        return false;

                    //Check Rows
                    if (board[i][j] != '.') uniqueRowValues.Add(board[i][j], 0);
                    //Check Cols
                    if (board[j][i] != '.') uniqueColValues.Add(board[j][i], 0);
                    //Check Subbox
                    if (board[startRowIndex][startColIndex] != '.') 
                        uniqueSubBoxValues.Add(board[startRowIndex][startColIndex], 0);
                    
                    if (startColIndex + 1 >= topLeftSubBoxColIndex + 3)
                    {
                        startRowIndex += 1;
                        startColIndex = topLeftSubBoxColIndex;
                    }
                    else 
                    {
                        startColIndex += 1;    
                    }
                }

                //Check to see if 3rd SubBox is reached
                if (topLeftSubBoxColIndex + 3 > 8) 
                {
                    topLeftSubBoxRowIndex += 3;
                    topLeftSubBoxColIndex = 0;
                }
                else 
                {
                    topLeftSubBoxColIndex += 3;
                }
            }
            return true;
        }
    }
}
