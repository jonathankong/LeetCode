using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class DetectCapital
    {
        public static bool Solution(string word)
        {
            if (word.Length == 1) return true;

            int index = 0;

            if (char.IsUpper(word[index]))
            {
                index += 1;
                if (char.IsUpper(word[index]))
                {
                    for (int i = index; i < word.Length; i++)
                    {
                        if (char.IsLower(word[i])) return false;
                    }
                }
                else if (char.IsLower(word[index]))
                {
                    for (int i = index; i < word.Length; i++)
                    {
                        if (char.IsUpper(word[i])) return false;
                    }
                }
            }
            else
            {
                for (int i = index; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i])) return false;
                }
            }

            return true;
        }
    }
}
