using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeSolutions
{
    static class GroupAnagrams
    {
        public static IList<IList<string>> Solution(string[] strs)
        {
            #region First Answer
        //     Dictionary<int, IList<string>> keyValuePairs = new Dictionary<int, IList<string>>();
        //     var asciiA = 'a';

        //     //Calculate total char value for each string and add it to the dictionary

        //     for (int i = 0; i < strs.Length; i++)
        //     {
        //         var countChars = new int[26];
        //         foreach(char c in strs[i])
        //         {
        //             countChars[c - asciiA]++;
        //         }

        //         var hash = CalculateHash(countChars);

        //         if (keyValuePairs.ContainsKey(hash))
        //         {
        //             keyValuePairs[hash].Add(strs[i]);
        //         }
        //         else
        //         {
        //             keyValuePairs.Add(hash, new List<string>() { strs[i] });
        //         }
        //     }

        //     IList<IList<string>> answers = new List<IList<string>>();
        //     foreach(var val in keyValuePairs.Values)
        //     {
        //         answers.Add(new List<string>(val));
        //     }

        //     return answers;
            #endregion

            #region Redoing First Answer from scratch
                //instead of sorting each string, just keep track of count of each character in string
                //in an array and store the list of strings in a dictionary
                Dictionary<int, IList<string>> anagramGroupsDict = 
                    new Dictionary<int, IList<string>>();
                IList<IList<string>> answerList = new List<IList<string>>();

                foreach (string str in strs)
                {
                    //This array only holds 26 representing 26 lower chars per constraint
                    int[] countChars = new int[26];
                    foreach (char c in str)
                    {
                        countChars[c - 'a']++;
                    }

                    int hash = CalculateHash(countChars);

                    //Try adding new entry into dictionary
                    //If not, add to existing list
                    if (!anagramGroupsDict.TryAdd(hash, new List<string>{str}))
                        anagramGroupsDict[hash].Add(str);
                }

                foreach (KeyValuePair<int, IList<string>> kvp in anagramGroupsDict)
                {
                    answerList.Add(kvp.Value);
                }     
                
                return answerList;
            #endregion
        }
        
        private static int CalculateHash(int[] countChars)
        {
            int hash = 17;
            for (int i = 0; i < countChars.Length; i++)
            {
                hash = hash * 19 + countChars[i];
            }
            return hash;
        }
    }
}
