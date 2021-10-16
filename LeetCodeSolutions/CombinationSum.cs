using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class CombinationSum
    {
        public static IList<IList<int>> Solution(int[] candidates, int target)
        {
            IList<int> memo = new List<int>();
            IList<IList<int>> answers = new List<IList<int>>();
            //Order list from lowest to highest to make things easier
            Array.Sort(candidates);

            Recursion(candidates, target, memo, new List<int>(), answers);

            return answers;
        }

        private static void Recursion(int[] candidates, int target, IList<int> memo, IList<int> candidateAnswer, IList<IList<int>> answers)
        {
            //Go through each candidate
            for (int i = 0; i < candidates.Length; i++)
            {
                //Keep track of temporary answer
                IList<int> tempAnswer = new List<int>(candidateAnswer);
                tempAnswer.Add(candidates[i]);

                var tempTarget = target - candidates[i];

                //If subtraction result has been done already, go to the next candidate in case new answer exists
                if (memo.Contains(tempTarget)) continue;
                
                //
                if (tempTarget == 0)
                {
                    answers.Add(tempAnswer);
                    return;
                }
                //Ignore loop because later candidates will result in the same thing
                else if (tempTarget < 0)
                {
                    return;
                }

                memo.Add(tempTarget);
                Recursion(candidates, tempTarget, memo, tempAnswer, answers);
            }
        }
    }
}
