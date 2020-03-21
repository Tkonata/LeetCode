/*
 * @lc app=leetcode id=111 lang=csharp
 *
 * [111] Minimum Depth of Binary Tree
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
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;
        if(root.left == null && root.right == null) return 1;
        int _minDepth = Int32.MaxValue;
        if(root.left != null) _minDepth = Math.Min(MinDepth(root.left), _minDepth);
        if(root.right != null) _minDepth = Math.Min(MinDepth(root.right), _minDepth);
        return _minDepth + 1;
    }
}
// @lc code=end

