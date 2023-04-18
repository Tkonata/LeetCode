/*
 * @lc app=leetcode id=106 lang=csharp
 *
 * [106] Construct Binary Tree from Inorder and Postorder Traversal
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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        if(inorder.Length == 0) return null;
        var root = new TreeNode(postorder.Last());
        var index = Array.IndexOf(inorder, root.val);
        root.left = BuildTree(inorder.Take(index).ToArray(), postorder.Take(index).ToArray());
        root.right = BuildTree(inorder.Skip(index + 1).ToArray(), postorder.Skip(index).SkipLast(1).ToArray());
        return root;
    }
}
// @lc code=end

