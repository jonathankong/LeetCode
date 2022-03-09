using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public static class CheckInclusion
    {
        public static bool Solution(string s1, string s2)
        {
            //First Solution using loop to generate a dictionary to keep track of letters in s1
            //and 2 loops (nested) to go through s2 and check if substring has all letters in dictionary
            
            //We're trying to find permutations of s1 in s2.  If s1 is bigger then no need to look
            #region First Solution
            // if (s1.Length > s2.Length) return false;
            
            // Dictionary<char, int> permDict = new Dictionary<char, int>();

            // //Keep track of all instances of letters in s1
            // for (int i = 0; i < s1.Length; i++)
            // {   
            //     if (permDict.ContainsKey(s1[i])) permDict[s1[i]] += 1;
            //     else permDict.Add(s1[i], 1);
            // }
            
            // int counter = 0;
            
            // //Go through s2 and create a copy of dictionary
            // //Remove values from dictionary based on the substrings of s2
            // //If the copy dictionary is empty, that means that s1 is in s2
            // while (counter + s1.Length - 1 < s2.Length)
            // {
            //     var tempDict = new Dictionary<char, int>(permDict);
            //     for (int i = counter; i < s2.Length; i++)
            //     {
            //         if (tempDict.ContainsKey(s2[i]))
            //         {
            //             if (tempDict[s2[i]] > 1) tempDict[s2[i]] -= 1;
            //             else tempDict.Remove(s2[i]);
            //         }
            //         else break;
            //     }

            //     if (tempDict.Count == 0) return true;
            //     counter += 1;
            // }
            // return false;
            #endregion

            //This solution came about after looking at some other people's answers.
            //Instead of using a dictionary to keep track of letters, we'll use an array 
            //to keep track of s1 characters.
            //s1 characters will be removed from the array and if all characters are removed, 
            //then a permutation of s1 exists in s2.
            #region Second Solution
            
            if (s1.Length > s2.Length) return false;
                    
            //Using arrays to keep track of characters
            int[] s1arr = new int[26];
            
            //Keep track of all instances of letters in s1
            foreach (var c in s1)
            {   
                s1arr[c - 'a']++;
            }

            //Loop acts as moving window for s2
            for (int startIndex = 0, currIndex = 0; currIndex < s2.Length; currIndex++)
            {
                int s2char = s2[currIndex] - 'a';
            
                //Take away from s1 array
                s1arr[s2char]--;
                
                //if a negative value is in the s1 array, that means the character in s2 window doesn't exist in s1
                //Re add all values taken away including the one that didn't exist to rebuild the s1 array
                //Move the start of the window to the right;
                while (s1arr[s2char] < 0)
                {
                    s1arr[s2[startIndex] - 'a']++;
                    startIndex++;
                }

                //If the latest current character is out of the s1 array and the window matches the s1 string length
                //that means s1 permutation exists in s2
                if (currIndex - startIndex + 1 == s1.Length && s1arr[s2char] == 0) return true;
            }
            
            return false;

            #endregion
        }
    }
}