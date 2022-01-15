using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions
{
    class DeepestLeavesSum
    {
        //int deepestNodeLevel = 0;
        //int answer = 0;
        //public int DeepestLeavesSum(TreeNode root)
        //{
        //    Recursion(root);
        //    return answer;
        //}

        //private void Recursion(TreeNode root, int level = -1)
        //{
        //    if (root == null) return;
        //    level += 1;
        //    //This checks to see if we're at the end of one of the branches.
        //    if (root.left == null && root.right == null)
        //    {
        //        if (level > deepestNodeLevel)
        //        {
        //            deepestNodeLevel = level;
        //            answer = root.val;
        //        }
        //        else if (level == deepestNodeLevel)
        //        {
        //            answer += root.val;
        //        }
        //        return;
        //    }

        //    Recursion(root.left, level);
        //    Recursion(root.right, level);
        //}
    }
}
