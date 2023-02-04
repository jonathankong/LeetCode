using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class IsValidSudoku
    {
        public static bool Solution(char[][] board)
        {

            #region First Answer
            //First answer was too complicated 

            // //Use two loops to check both rows and columns at the same time
            // //This is done by using one loop as traversing 1 of the 9 rows/cols and the nested loop to
            // //traverse through that array
            
            // int topLeftSubBoxRowIndex = 0;
            // int topLeftSubBoxColIndex = 0;
            
            // for (int i = 0; i < board.Length; i++)
            // {
            //     Dictionary<int, int> uniqueRowValues = new Dictionary<int, int>();
            //     Dictionary<int, int> uniqueColValues = new Dictionary<int, int>();
            //     Dictionary<int, int> uniqueSubBoxValues = new Dictionary<int, int>();
          
            //     int startRowIndex = topLeftSubBoxRowIndex;
            //     int startColIndex = topLeftSubBoxColIndex;
                
            //     for (int j = 0; j < board[0].Length; j++)
            //     {
            //         if (uniqueRowValues.ContainsKey(board[i][j]) || uniqueColValues.ContainsKey(board[j][i])
            //         || uniqueSubBoxValues.ContainsKey(board[startRowIndex][startColIndex]))
            //             return false;

            //         //Check Rows
            //         if (board[i][j] != '.') uniqueRowValues.Add(board[i][j], 0);
            //         //Check Cols
            //         if (board[j][i] != '.') uniqueColValues.Add(board[j][i], 0);
            //         //Check Subbox
            //         if (board[startRowIndex][startColIndex] != '.') 
            //             uniqueSubBoxValues.Add(board[startRowIndex][startColIndex], 0);
                    
            //         if (startColIndex + 1 >= topLeftSubBoxColIndex + 3)
            //         {
            //             startRowIndex += 1;
            //             startColIndex = topLeftSubBoxColIndex;
            //         }
            //         else 
            //         {
            //             startColIndex += 1;    
            //         }
            //     }

            //     //Check to see if 3rd SubBox is reached
            //     if (topLeftSubBoxColIndex + 3 > 8) 
            //     {
            //         topLeftSubBoxRowIndex += 3;
            //         topLeftSubBoxColIndex = 0;
            //     }
            //     else 
            //     {
            //         topLeftSubBoxColIndex += 3;
            //     }
            // }
            // return true;
            #endregion

            #region Second Answer
            //I think my second answer was a quicker solution to implement.  

            // //Review each row by using a dictionary and trying to insert char as key except periods.
            // //If can't insert new key, then that means there's a duplicate in that row.
            // foreach (var row in board)
            // {
            //     Dictionary<char, int> uniqueValuesDict = new Dictionary<char, int>();
            //     foreach (var value in row)
            //     {
            //         if (value != '.' && uniqueValuesDict.TryAdd(value, 0) == false)
            //         {
            //             return false;
            //         }
            //     }
            // }

            // //We're going to use the same method with the columns 
            // for (int j = 0; j < board.Length; j++)
            // {
            //     Dictionary<char, int> uniqueValuesDict = new Dictionary<char, int>();
            //     for (int i = 0; i < board[j].Length; i++)
            //     {
            //         char value = board[i][j];
            //         if (value != '.' && uniqueValuesDict.TryAdd(value, 0) == false)
            //         {
            //             return false;
            //         }
            //     }
            // }

            // //Finally review each block using the same method above
            // for (int nextRow = 0; nextRow < 3; nextRow++)
            // {
            //     for (int nextBlock = 0; nextBlock < 3; nextBlock++)
            //     {
            //         Dictionary<char, int> uniqueValuesDict = new Dictionary<char, int>();
            //         for (int i = 0; i < 3; i++)
            //         {
            //             for (int j = 0; j < 3; j++)
            //             {
            //                 char value = board[i + (nextRow * 3)][j + (nextBlock * 3)];
            //                 if (value != '.' && uniqueValuesDict.TryAdd(value, 0) == false)
            //                 {
            //                     return false;
            //                 }
            //             }
            //         }
            //     }
            // }
            //return true;
            #endregion

            #region Third Answer
            //This takes advantage of sudoku bein a fixed length.  Not as flexible when it comes to larger boards

            //Since the grid is a fixed length and width, I'll use multiple dictionaries and only iterate through the grid once.
            Dictionary<char, int>[] rowsDictArr = new Dictionary<char, int>[] 
            {
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>()
            };

            Dictionary<char, int>[] colsDictArr = new Dictionary<char, int>[] 
            {
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>()
            };

            Dictionary<char, int>[] blocksDictArr = new Dictionary<char, int>[] 
            {
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>(),
                new Dictionary<char, int>()
            };


            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    //Skip periods
                    if (board[i][j] == '.') continue;

                    //Try to add to row dictionary
                    //Index of rowDictArr represents each index row in board

                    if (!rowsDictArr[i].TryAdd(board[i][j], 0)) return false;

                    //Try to add to col dictionary
                    //Index of colDictArr represents each index col in board
                    if (!colsDictArr[j].TryAdd(board[i][j], 0)) return false;

                    //Use calculations to determine what block is being investigated
                    int blockIndex = 0;

                    //Normalize row and col indexes
                    int rowIndex = i / 3;
                    int colIndex = j / 3;

                    if (rowIndex == 0 && colIndex == 0) blockIndex = 0;
                    else if (rowIndex == 0 && colIndex == 1) blockIndex = 1;
                    else if (rowIndex == 0 && colIndex == 2) blockIndex = 2;
                    else if (rowIndex == 1 && colIndex == 0) blockIndex = 3;
                    else if (rowIndex == 1 && colIndex == 1) blockIndex = 4;
                    else if (rowIndex == 1 && colIndex == 2) blockIndex = 5;
                    else if (rowIndex == 2 && colIndex == 0) blockIndex = 6;
                    else if (rowIndex == 2 && colIndex == 1) blockIndex = 7;
                    else if (rowIndex == 2 && colIndex == 2) blockIndex = 8;

                    if (!blocksDictArr[blockIndex].TryAdd(board[i][j], 0)) return false;
                }
            }

            return true;
            #endregion
        }
    }
}
