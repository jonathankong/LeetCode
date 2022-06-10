using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    public static class PascalTriangle
    {
        public static IList<IList<int>> Solution (int numRows)
        {
            List<IList<int>> answers = new List<IList<int>>();
            
            //Start from beginning of trangle to end and build each row
            for (int i = 1; i <= numRows; i++)
            {
                //Add 1 to the beginning and end of each row
                int[] tempAnswers = new int[i];
                tempAnswers[0] = 1;
                tempAnswers[i - 1] = 1;
                //If row number is 3 or more, then we'll need to fill in middle portion of row
                if (i >= 3)
                {
                    //add to index of row based on previous row
                    for (int j = 1; j < i - 1; j++)
                    {
                        tempAnswers[j] = answers[i - 2][j - 1] + answers[i - 2][j];
                    }
                }
                //Add answer to triangle
                answers.Add(tempAnswers.ToList<int>());
            }
            return answers;
        }
    }
}