using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    static class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode answer = new ListNode();
            var current1 = l1;
            var current2 = l2;
            var currentAns = answer;
            while (current1 != null || current2 != null)
            {
                int tempAns = 0;
                if (current1 == null)
                {
                    tempAns = current2.val;
                }
                else if (current2 == null)
                {
                    tempAns = current1.val;
                }
                else
                {
                    tempAns = current1.val + current2.val;
                }

                if (tempAns >= 10)
                {
                    tempAns = tempAns - 10;
                    currentAns.next = new ListNode(1, null);
                }
                currentAns.val = tempAns;
                current1 = current1.next;
                current2 = current2.next;
                answer = currentAns;
                currentAns = currentAns.next;
            }
            answer = ReverseLinkedList(answer);
            return answer;
        }

        public static ListNode ReverseLinkedList(ListNode ln)
        {
            ListNode newLinkedList = new ListNode();
            ListNode prevNode = new ListNode();
            var current = ln;
            while (current.next != null)
            {
                if (newLinkedList == null)
                {
                    newLinkedList = current;
                }
                else
                {
                    prevNode = current;
                    prevNode.next = newLinkedList;
                    newLinkedList = prevNode;
                }
                current = current.next;
            }
            return newLinkedList;
        }
    }
}

