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

        public void ToString()
        {
            while (this.next != null)
            {
                Console.WriteLine(this.val);
            }
        }
    }
    static class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode answer = new ListNode();
            var currentNode = answer;

            while (l1 != null || l2 != null || carry != 0)
            {
                var l1Value = l1 == null ? 0 : l1.val;
                var l2Value = l2 == null ? 0 : l2.val;

                currentNode.val = l1Value + l2Value + carry;
                carry = currentNode.val / 10;
                currentNode.val = currentNode.val % 10;

                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;

                if (l1 != null || l2 != null || carry != 0)
                {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }
            }
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

