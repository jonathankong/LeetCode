using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class EncodeDecodeStrings
    {
        //Encode will take list, append each word with character count and a delimiter for decode to disect
        public static string Encode(List<string> words)
        {
            StringBuilder answer = new StringBuilder();
            foreach (var word in words)
            {
                answer.Append(word.Length + "#" + word);
            }

            return answer.ToString();
        }

        public static List<string> Decode(string word)
        {
            List<string> answer = new List<string>();
            int startNumLength = 0;
            int endNumLength = 0;
            while (startNumLength < word.Length)
            {
                //Go through string and find instance of '#' delimiter
                while (word[endNumLength] != '#')
                {
                    endNumLength++;
                }

                //Once found, parse the word length in front of the delimiter and word itself after the delimiter
                if (int.TryParse(word.Substring(startNumLength, endNumLength - startNumLength), out int result))
                {
                    endNumLength++;
                    answer.Add(word.Substring(endNumLength, result));
                    endNumLength += result;
                    startNumLength = endNumLength;
                }
            }
            return answer;
        }
    }
}