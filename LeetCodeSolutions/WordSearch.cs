using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    public static class WordSearch
    {
        public static bool Solution(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0])
                    {
                        //Already found the first character so change it in the board so it doesn't get reused
                        board[i][j] = '!';
                        if (Recursion(i, j, ref board, word, 1)) return true;
                        else board[i][j] = word[0];
                    }
                }
            }

            return false;
        }

        private static bool Recursion(int x, int y, ref char[][] board, string word, int position)
        {
            if (position == word.Length) return true;

            //Find next character adjacent to current position in board
            //Check Up
            if (x - 1 >= 0 && board[x - 1][y] == word[position])
            {
                board[x - 1][y] = '!';
                if (!Recursion(x - 1, y, ref board, word, position + 1)) board[x - 1][y] = word[position];
                else return true;
            }
            //Check Down
            if (x + 1 < board.Length && board[x + 1][y] == word[position])
            {
                board[x + 1][y] = '!';
                if (!Recursion(x + 1, y, ref board, word, position + 1)) board[x + 1][y] = word[position];
                else return true;
            }
            //Check Left
            if (y - 1 ! >= 0 && board[x][y - 1] == word[position])
            {
                board[x][y - 1] = '!';
                if (!Recursion(x, y - 1, ref board, word, position + 1)) board[x][y - 1] = word[position];
                else return true;
            }
            if (y + 1 < board[0].Length && board[x][y + 1] == word[position])
            {
                board[x][y + 1] = '!';
                if (!Recursion(x, y + 1, ref board, word, position + 1)) board[x][y + 1] = word[position];
                else return true;
            }

            return false;
        }
    }
}
