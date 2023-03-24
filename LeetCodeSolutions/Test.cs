using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class Test
    {
        public static void Solution(int steps)
        {
            ListNode s = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode t = new ListNode(1, new ListNode(3, new ListNode(4)));

            var currNode1 = s;
            var currNode2 = t;
            AddNode(s, 20);
            currNode1 = currNode1.next;
            AddNode(s, 10);
        }
        private static void AddNode(ListNode s, int val)
        {
            var temp = s.next;
            s.next = new ListNode(val);
            s.next.next = temp;
        }
    }
}
