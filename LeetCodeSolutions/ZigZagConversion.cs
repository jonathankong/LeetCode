using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class ZigZagConversion
    {
        public static string Solution(string s, int numRows)
        {
            //build answer by creating sections of the answer using a dictionary based on number of rows
            //then iterating through the string and inserting each character into the dictionary in a zigzag pattern
            #region First Solution
            
            //Dictionary<int, StringBuilder> dict = new Dictionary<int, StringBuilder>();

            //if (s.Length <= numRows) return s;

            ////add keys
            //for (int i = 1; i <= numRows; i++)
            //{
            //    dict.Add(i, new StringBuilder());
            //}

            //int dictPointer = 1;
            //bool goRight = true;

            ////go through string and insert characters into dictionary while going up and down through the dictionary keys in a zigzag pattern
            //for (int i = 0; i < s.Length; i++)
            //{
            //    dict[dictPointer].Append(s[i]);

            //    if (dictPointer == numRows) goRight = false;
            //    else if (dictPointer == 1) goRight = true;

            //    if (goRight) dictPointer += 1;
            //    else dictPointer -= 1;
            //}

            ////concat strings together in dictionary
            //StringBuilder ans = new StringBuilder();

            //foreach (var kvPair in dict)
            //{
            //    ans.Append(kvPair.Value.ToString());
            //}

            //return ans.ToString();
            #endregion


            //Calculate position of characters for answer using math
            //First and last row do not have diagonal characters
            #region Second Solution
            StringBuilder ans = new StringBuilder();

            if (s.Length <= numRows || numRows == 1) return s;

            //for each row
            for (int i = 0; i < numRows; i++)
            {
                int counter = i;
                while (counter < s.Length)
                {
                    ans.Append(s[counter]);
                    //If first or last row, don't include diagonals
                    if (i == 0 || i == numRows - 1) counter += numRows * 2 - 2;
                    //If counter is at a column, calculate for diagonal
                    else if (counter % (2 * numRows - 2) == i) counter += 2 * numRows - 2 - 2 * i;
                    //if counter is at diagonal, add to get to column
                    else counter += 2 * i;
                }
            }

            return ans.ToString();
            #endregion
        }
    }
}
