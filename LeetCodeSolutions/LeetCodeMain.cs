using System;
using System.Linq;

namespace LeetCodeSolutions
{
    class LeetCodeMain
    {
        static void Main(string[] args)
        {
            //Two Sum
            //Console.WriteLine($"[{string.Join(", ", TwoSum.Solution(new int[] { 3, 2, 4 }, 6))}]");

            //Add Two Numbers

            //Create L1
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            Console.WriteLine(AddTwoNumbers.Solution(l1, l2));
        }
    }
}
