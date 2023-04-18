/*
 * @lc app=leetcode id=105 lang=csharp
 *
 * [105] Construct Binary Tree from Preorder and Inorder Traversal
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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if(preorder.Length == 0) return null;
        var root = new TreeNode(preorder[0]);
        var index = Array.IndexOf(inorder, root.val);
        root.left = BuildTree(preorder.Skip(1).Take(index).ToArray(), inorder.Take(index).ToArray());
        root.right = BuildTree(preorder.Skip(index + 1).ToArray(), inorder.Skip(index + 1).ToArray());
        return root;
    }
}
// @lc code=end

