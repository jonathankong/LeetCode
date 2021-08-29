using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{
    static class IntegerToEnglishWords
    {
        private static IDictionary<int, string> numsInEng = new Dictionary<int, string>(){
                { 1, "One" },
                { 2, "Two" },
                { 3, "Three" },
                { 4, "Four" },
                { 5, "Five" },
                { 6, "Six" },
                { 7, "Seven" },
                { 8, "Eight" },
                { 9, "Nine" },
                { 10, "Ten" },
                { 11, "Eleven" },
                { 12, "Twelve" },
                { 13, "Thirteen" },
                { 14, "Fourteen" },
                { 15, "Fifteen" },
                { 16, "Sixteen" },
                { 17, "Seventeen" },
                { 18, "Eighteen" },
                { 19, "Nineteen" },
                { 20, "Twenty" },
                { 30, "Thirty" },
                { 40, "Forty" },
                { 50, "Fifty" },
                { 60, "Sixty" },
                { 70, "Seventy" },
                { 80, "Eighty" },
                { 90, "Ninety" },
            };
        public static string Solution1 (int num)
        {
            StringBuilder answer = new StringBuilder();
            var numLength = num.ToString().Length;




            for (int i = (numLength - 1) / 3; i >= 0; i--)
            {
                var tempNum = num / (int)Math.Pow(10, i * 3) % 1000;
                if (tempNum != 0)
                {
                    switch (i)
                    {
                        case 3:
                            answer.Append(int2String(tempNum, numsInEng) + "Billion ");
                            break;
                        case 2:
                            answer.Append(int2String(tempNum, numsInEng) + "Million ");
                            break;
                        case 1:
                            answer.Append(int2String(tempNum, numsInEng) + "Thousand ");
                            break;
                        case 0:
                            answer.Append(int2String(tempNum, numsInEng));
                            break;
                    }
                }    
            }
            return answer.Length == 0 ? "Zero" : answer.ToString().Trim();
        }

        static string int2String(int num, IDictionary<int, string> numsInEng)
        {
            var numLength = num.ToString().Length;
            StringBuilder answer = new StringBuilder();

            for (int i = numLength; i > 0; i--)
            {
                var modVal = num % (int)Math.Pow(10, i);
                var placeVal = modVal / (int)Math.Pow(10, i - 1);

                switch (i)
                {
                    case 3:
                        answer.Append(numsInEng.ContainsKey(placeVal) ? numsInEng[placeVal] + " Hundred " : "");
                        break;
                    case 2:
                        if (modVal > 9 && modVal < 20)
                        {
                            answer.Append(numsInEng.ContainsKey(modVal) ? numsInEng[modVal] + ' ' : "");
                            i--;
                        }
                        else
                        {
                            modVal = modVal / 10 * 10;
                            answer.Append(numsInEng.ContainsKey(modVal) ? numsInEng[modVal] + ' ' : "");
                        }
                        break;
                    case 1:
                        answer.Append(numsInEng.ContainsKey(placeVal) ? numsInEng[placeVal] + ' ' : "");
                        break;
                }
            }
            return answer.ToString();
        }
    }
}
