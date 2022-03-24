using System;
using System.Text;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class RewrapAndJustify
    {
        // public static List<string> Solution(string[] lines, int charLimit)
        // {
        //     List<string> answers = new List<string>();
        //     StringBuilder remainderSentence = new StringBuilder("");
        //     int remainderHyphens = 0;
        //     int counter = 0;

        //     while (counter < lines.Length)
        //     {
        //         if (remainderSentence.Length > 0 && remainderSentence.Length < charLimit)
        //         {
                    
        //         }
        //         int endOfSentence = charLimit - remainderSentence.Length;

        //         while (line[endOfSentence] != ' ')
        //         {
        //             endOfSentence--;
        //         }

        //         StringBuilder tempLine = new StringBuilder(
        //             (remainderSentence.ToString() + ' ' + line.Substring(0, endOfSentence)).Trim()
        //         );
        //         remainderSentence.Clear();
        //         remainderSentence.Append(line.Substring(endOfSentence).Trim());

        //         for (int i = 0; i < tempLine.Length; i++)    
        //         {
        //             if (tempLine[i] == ' ') tempLine[i] = '-';
        //         }

        //         answers.Add(tempLine.ToString());
        //     }
        //     return answers;
        // }
    }
}