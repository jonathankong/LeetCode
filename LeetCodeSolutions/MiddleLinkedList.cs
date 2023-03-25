using System;

namespace LeetCodeSolutions
{
    public static class MiddleLinkedList
    {
        public static ListNode Solution(ListNode head)
        {
            #region First Answer
            // //If there's only one node
            // if (head.next == null) return head;
            
            // int nodeCounter = 1;
            
            // ListNode answer = head;
            // ListNode currNode = head;
            
            // while (currNode != null)
            // {
            //     //If the current node counter is even, that means we need to move the answer up the linked list
            //     if (nodeCounter % 2 == 0) answer = answer.next;
                
            //     currNode = currNode.next;
            //     nodeCounter += 1;
            // }
            
            // return answer;
            #endregion

            //Cleaner solution after coming back to answer it after a year
            #region Second Answer
            int count = 0;
            ListNode midNode = head;
            ListNode currNode = head;

            while (currNode != null)
            {
                count++;
                if (count % 2 == 0) midNode = midNode.next;
                currNode = currNode.next;

            }
            return midNode;
            #endregion
        }
    }
}