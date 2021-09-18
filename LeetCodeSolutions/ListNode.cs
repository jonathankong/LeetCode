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

        public void PrintValues()
        {
            var currentNode = this;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.val);
                currentNode = currentNode.next;
            }
        }
    }
}
