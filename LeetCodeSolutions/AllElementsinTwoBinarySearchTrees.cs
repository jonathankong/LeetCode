using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public static class AllElementsinTwoBinarySearchTrees
    {
        public static IList<int> Solution()
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));

            IList<int> answers = new List<int>();
            if (root == null) return null;
            
            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            while (true)
            {
                if (root != null)
                {
                    treeStack.Push(root);
                    root = root.left;
                }
                else 
                {
                    if (treeStack.Count == 0) break;
                    answers.Add(treeStack.Pop().val);
                    root = root.right;
                }
            }

            return answers;
        }

        // public static IList<int> Solution(TreeNode root1, TreeNode root2)
        // {
        //     root1 = new TreeNode(1, new TreeNode(0), new TreeNode(3));
        //     root2 = new TreeNode(2, new TreeNode(1), new TreeNode(4));

        //     IList<int> ans = new List<int>();
        //     Stack<TreeNode> rootStack1 = new Stack<TreeNode>();
        //     Stack<TreeNode> rootStack2 = new Stack<TreeNode>();

        //     //Traverse all the way to the left of both Tree
        //     TraverseLeftSide(root1, ref rootStack1);
        //     TraverseLeftSide(root2, ref rootStack2);

        //     TreeNode currentNode1 = rootStack1.Pop();
        //     TreeNode currentNode2 = rootStack2.Pop();

        //     while (currentNode1 != null || currentNode2 != null)
        //     {
        //         if ((currentNode2 == null && currentNode1 != null) || 
        //             (currentNode1 != null && currentNode1.val <= currentNode2.val))
        //         {
        //             ans.Add(currentNode1.val);
        //             int prevStackCount = rootStack1.Count;
        //             TraverseRightSide(currentNode1.right, ref rootStack1);
        //             TraverseLeftSide(currentNode1.left, ref rootStack1);
        //             if (rootStack1.Count == 0) currentNode1 = null;
        //             else currentNode1 = rootStack1.Pop();
        //         }
        //         else if ((currentNode1 == null && currentNode2 != null) || 
        //             (currentNode2 != null && currentNode1.val > currentNode2.val))
        //         {
        //             ans.Add(currentNode2.val);
        //             int prevStackCount = rootStack2.Count;
        //             TraverseRightSide(currentNode2.right, ref rootStack2);
        //             TraverseLeftSide(currentNode2.left, ref rootStack2);
        //             if (rootStack2.Count == 0) currentNode2 = null;
        //             else currentNode2 = rootStack2.Pop();
        //         }
        //     }

        //     return ans;
        // }

        // private static void TraverseLeftSide(TreeNode root, ref Stack<TreeNode> rootStack)
        // {
        //     while (root != null)
        //     {
        //         var temp = root.left;
        //         root.left = null;
        //         rootStack.Push(root);
        //         root = temp;
        //     }
        // }

        // private static void TraverseRightSide(TreeNode root, ref Stack<TreeNode> rootStack)
        // {
        //     while (root != null)
        //     {
        //         var temp = root.right;
        //         root.right = null;
        //         rootStack.Push(root);
        //         root = temp;
        //     }
        // }
    }
}
