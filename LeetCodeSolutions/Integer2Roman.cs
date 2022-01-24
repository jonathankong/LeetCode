using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public static class Integer2Roman
    {
        public static string Solution(int num)
        {
            StringBuilder ans = new StringBuilder();
            Dictionary<int, string> roman1s = new Dictionary<int, string>()
            {
                {1, "I"},
                {4, "IV"},
                {5, "V"},
                {9, "IX"}
            };

            Dictionary<int, string> roman10s = new Dictionary<int, string>()
            {
                {1, "X"},
                {4, "XL"},
                {5, "L"},
                {9, "XC"}
            };

            Dictionary<int, string> roman100s = new Dictionary<int, string>()
            {
                {1, "C"},
                {4, "CD"},
                {5, "D"},
                {9, "CM"}
            };

            Dictionary<int, string> roman1000s = new Dictionary<int, string>()
            {
                {1, "M"}
            };

            int baseNum = 1;

            while (num > 0)
            {
                StringBuilder tempAns = new StringBuilder();
                int extractedVal = num % 10;
                Dictionary<int, string> dictToUse = null;

                switch (baseNum)
                {
                    case 1:
                        dictToUse = roman1s;
                        break;
                    case 2:
                        dictToUse = roman10s;
                        break;
                    case 3:
                        dictToUse = roman100s;
                        break;
                    case 4:
                        dictToUse = roman1000s;
                        break;
                    default:
                        break;
                }

                //Build roman number
                if (dictToUse != null)
                {
                    while (extractedVal > 0)
                    {
                        int val = 0;

                        if (extractedVal == 9) val = 9;
                        else if (extractedVal >= 5) val = 5;
                        else if (extractedVal == 4) val = 4;
                        else val = 1;

                        tempAns.Append(dictToUse[val]);
                        extractedVal -= val;
                    }
                }

                ans.Insert(0, tempAns.ToString());

                baseNum += 1;
                num /= 10;
            }

            return ans.ToString();
        }
    }
}
