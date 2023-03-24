using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    static class MergeTwoSortedLists
    {
        public static ListNode Solution(ListNode list1, ListNode list2)
        {
            //Created a new ListNode and filled it in
            #region First Answer;
            // if (list1 == null && list2 == null) return null;

            // var answer = new ListNode();
            // var currentNode = answer;

            // while (list1 != null || list2 != null)
            // {
            //     if (list2 == null || list1 != null && list1.val <= list2.val)
            //     {
            //         currentNode.val = list1.val;
            //         list1 = list1.next;
            //     }
            //     else
            //     {
            //         currentNode.val = list2.val;
            //         list2 = list2.next;
            //     }

            //     if (list1 != null || list2 != null)
            //     {
            //         currentNode.next = new ListNode();
            //         currentNode = currentNode.next;
            //     }
            // }

            // return answer;
            #endregion 

            //Using list1 as a base.  
            #region Second Answer
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1 == null && list2 == null) return null;
            
            //Making sure list1 starts less than list2
            if (list1.val > list2.val)
            {
                var temp = list1;
                list1 = list2;
                list2 = temp;
            }

            var currNode1 = list1;
            var currNode2 = list2;
            var prevNode1 = list1;

            while (currNode1 != null)
            {
                //There's no more nodes to add to list1
                if (currNode2 == null) break;
                while (currNode1 != null && currNode1.val < currNode2.val)
                {
                    prevNode1 = currNode1;
                    currNode1 = currNode1.next;
                }
                
                //If end of list1 but still nodes in list2 to traverse, 
                //just add rest of list2 to list 1
                if (currNode1 == null)
                {
                    prevNode1.next = currNode2;
                    break;
                }

                //Add list2 value to list1
                NodeAdd(prevNode1, currNode2.val);
                currNode2 = currNode2.next;
                prevNode1 = prevNode1.next;
            }
            return list1;
            #endregion
        }

        private static void NodeAdd(ListNode list, int val)
        {
            var temp = list.next;
            list.next = new ListNode(val);
            list.next.next = temp;
        }
    }
}
