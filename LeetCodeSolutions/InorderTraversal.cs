using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    class InorderTraversal
    {
        // Recursion
        // public IList<int> InorderTraversal(TreeNode root)
        // {
        //    List<int> answers = new List<int>();
        //    InorderTraversal(ref answers, root);
        //    return answers;
        // }

        // private void InorderTraversal(ref List<int> answers, TreeNode root)
        // {
        //    if (root == null) return;

        //    InorderTraversal(ref answers, root.left);
        //    answers.Add(root.val);
        //    InorderTraversal(ref answers, root.right);
        //    return;
        // }

        // Second Solution (Iterative)
        // private void InorderTraversal(ref List<int> answers, TreeNode root)
        // {
        //     IList<int> answers = new List<int>();
        //     if (root == null) return answers;
            
        //     Stack<TreeNode> treeStack = new Stack<TreeNode>();
        //     while (true)
        //     {
        //         if (root != null)
        //         {
        //             treeStack.Push(root);
        //             root = root.left;
        //         }
        //         else 
        //         {
        //             if (treeStack.Count == 0) break;
        //             root = treeStack.Pop();
        //             answers.Add(root.val);
        //             root = root.right;
        //         }
        //     }

        //     return answers;
        // }
    }
}
