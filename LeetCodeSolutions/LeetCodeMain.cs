using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{
    class LeetCodeMain
    {
        static void Main(string[] args)
        {
            //Two Sum
            //Console.WriteLine($"[{string.Join(", ", TwoSum.Solution(new int[] { 3, 2, 4 }, 6))}]");

            //Add Two Numbers
            //ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            //RemoveNthNode.Solution(l1, 2).PrintValues();
            //ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            //Console.WriteLine(AddTwoNumbers.Solution(l1, l2));



            //Longest Substring Without Repeating Characters
            //Console.WriteLine(LongestSubstringWithoutRepeatChars.Solution("Hello"));

            //Largest Palindrome in Substring
            //Console.WriteLine(LargestPalindromeSubString.Solution("babad"));

            //Reverse Integer
            //Console.WriteLine(ReverseInteger.Solution(1534236469));

            //Integer to English Words

            //IList<IList<int>> s = new List<IList<int>>();
            //Console.WriteLine(IntegerToEnglishWords.Solution1(12345));

            //Console.WriteLine(RecursionExercise1.Solution(6));
            //Console.WriteLine(RecursionExercise2.Solution(new int[] { 0, 12, 0, -100, 5, -11 }));
            //Console.WriteLine(RecursionExercise3.Solution(new int[] { 1, 2, 3, 4, 5, 6 }));
            //Console.WriteLine(RecursionExercise4.Solution(new char[] { 'k', 'a', 'y', 'y', 'a', 'k' }));


            //Console.WriteLine(Permutations.Solution(new int[] { 1, 2, 3 }));

            //Remove Nth Node
            //ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            //RemoveNthNode.Solution(l1, 2).PrintValues();

            //Valid Parentheses
            //Console.WriteLine(ValidParentheses.Solution("()"));
            //Console.WriteLine(ValidParentheses.Solution("([])"));
            //Console.WriteLine(ValidParentheses.Solution("]([)]"));

            //Merge Two Sorted Lists
            //ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            //ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            //MergeTwoSortedLists.Solution(l1, l2).PrintValues();

            //Generate Parentheses
            //foreach(string s in GenerateParenthesis.Solution(3))
            //{
            //    Console.WriteLine(s);
            //}

            //Search in Rotated Sorted Array
            //Console.WriteLine(SearchRotatedSortedArray.Solution(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0));

            //Find First and Last Position of Element in Sorted Array
            var i = FindFirstAndLastPosition.Solution(new int[] { 5,7,7,8,8,10 }, 8);
            Console.WriteLine($"Target = {i[0]}, Position = {i[1]}");
        }
    }
}
