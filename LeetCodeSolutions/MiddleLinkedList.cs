using System;

namespace LeetCodeSolutions
{
    public static class MiddleLinkedList
    {
        public static ListNode Solution(ListNode head)
        {
            //If there's only one node
            if (head.next == null) return head;
            
            int nodeCounter = 1;
            
            ListNode answer = head;
            ListNode currNode = head;
            
            while (currNode != null)
            {
                //If the current node counter is even, that means we need to move the answer up the linked list
                if (nodeCounter % 2 == 0) answer = answer.next;
                
                currNode = currNode.next;
                nodeCounter += 1;
            }
            
            return answer;
        }
    }
}