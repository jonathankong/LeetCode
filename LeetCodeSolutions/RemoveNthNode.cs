using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class RemoveNthNode
    {
        public static ListNode Solution(ListNode head, int n)
        {
            int listNodeLength = 1;
            var currentNode = head;

            //Get length of linked list first
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
                listNodeLength++;
            }
            //Reset currentNode back to head of linked list
            currentNode = head;

            //Return next in linked list if head is going to be removed
            if (listNodeLength - n == 0) return head.next;
            else
            {
                for (int i = 1; i < listNodeLength - n; i++)
                {
                    currentNode = currentNode.next;
                }

                currentNode.next = currentNode.next.next;
            }
            return head;
        }
    }
}
