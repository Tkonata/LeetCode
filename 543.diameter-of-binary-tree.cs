/*
 * @lc app=leetcode id=543 lang=csharp
 *
 * [543] Diameter of Binary Tree
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
    private int maxL = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Depth(root);
        return maxL;
    }

    private int Depth(TreeNode root) {
        if(root == null)
            return 0;
        var left = Depth(root.left);
        var right = Depth(root.right);
        maxL = Math.Max(left + right, maxL);
        return Math.Max(left, right) + 1;
    }
}
// @lc code=end

