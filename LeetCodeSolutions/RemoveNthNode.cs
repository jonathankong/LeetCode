using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class RemoveNthNode
    {
        public static ListNode Solution(ListNode head, int n)
        {
            //First Solution (first loop through and count nodes, then loop through again to find and remove node)
            #region First Solution
            // int listNodeLength = 1;
            // var currentNode = head;

            // while (currentNode.next != null)
            // {
            //     currentNode = currentNode.next;
            //     listNodeLength++;
            // }

            // currentNode = head;
            // if (listNodeLength == 1 && n == 1) return null;
            // else if (listNodeLength - n == 0) return head.next;
            // else
            // {
            //     for (int i = 1; i < listNodeLength - n; i++)
            //     {
            //         currentNode = currentNode.next;
            //     }

            //     currentNode.next = currentNode.next.next;
            // }
            // return head;
            #endregion
        
            //Second Solution
            #region Second Solution
            var currNode = head;
            var answer = head;
            
            int nodeCounter = 0;
            
            while (currNode != null)
            {
                //Move pointer only when the diff between nodeCounter and n is greater than 1
                //Otherwise, this means that the current known length of the list isn't large enough
                //to find the node to remove
                
                //The node to remove changes as we know more about the linkedlist length
                if (nodeCounter - n > 0) answer = answer.next;
                
                currNode = currNode.next;
                nodeCounter += 1;
            }
            
            //This means that we are removing the head of the linkedlist
            if (nodeCounter - n == 0) return head.next;
            //Remove node by changing ListNode pointer
            answer.next = answer.next.next;
            
            return head;
            #endregion
        }
    }
}
