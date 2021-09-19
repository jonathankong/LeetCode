using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class MergeTwoSortedLists
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;

            var answer = new ListNode();
            var currentNode = answer;

            while (l1 != null || l2 != null)
            {
                if (l2 == null || l1 != null && l1.val <= l2.val)
                {
                    currentNode.val = l1.val;
                    l1 = l1.next;
                }
                else
                {
                    currentNode.val = l2.val;
                    l2 = l2.next;
                }

                if (l1 != null || l2 != null)
                {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }
            }

            return answer;
        }
    }
}
