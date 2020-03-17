/*
 * @lc app=leetcode id=98 lang=csharp
 *
 * [98] Validate Binary Search Tree
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
    public bool IsValidBST(TreeNode root) {
        return Recursion(root, null, null);
    }

    private bool Recursion(TreeNode root, TreeNode min, TreeNode max) {
        if(root == null) return true;
        if(min != null && root.val <= min.val) return false;
        if(max != null && root.val >= max.val) return false;
        return Recursion(root.left, min, root) && Recursion(root.right, root, max);
    }
}
// @lc code=end

