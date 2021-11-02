using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    static class MergeIntervals
    {
        public static int[][] Solution (int[][] intervals)
        {
            IList<int[]> answers = new List<int[]>();
            int[] tempAnswer = intervals[0];
            int counter = 1;

            while (counter < intervals.Length)
            {
                if (intervals[counter][0] <= tempAnswer[0] && intervals[counter][1] >= tempAnswer[1])
                {
                    tempAnswer = intervals[counter];
                }
                else if (intervals[counter][0] <= tempAnswer[1])
                {
                    tempAnswer[1] = intervals[counter][1];
                }
                else if (intervals[counter][0] <= tempAnswer[0])
                {
                    tempAnswer[0] = intervals[counter][0];
                }
                else
                {
                    answers.Add(tempAnswer);
                    tempAnswer = intervals[counter];
                }
                counter++;
            }
            answers.Add(tempAnswer);
            return answers.ToArray();
        }
    }
}
