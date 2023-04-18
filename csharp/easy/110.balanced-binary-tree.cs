/*
 * @lc app=leetcode id=110 lang=csharp
 *
 * [110] Balanced Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public bool IsBalanced(TreeNode root) {
        if(Recur(root) == -1)
            return false;
        else
            return true;
    }

    private int Recur(TreeNode root) {
        if(root == null) return 0;
        int leftLength = Recur(root.left);
        if(leftLength == -1)
            return -1;
        int rightLength = Recur(root.right);
        if(rightLength == -1)
            return -1;
        return Math.Abs(leftLength - rightLength) > 1 ? -1 : (Math.Max(leftLength, rightLength) + 1);
    }
}
// @lc code=end

