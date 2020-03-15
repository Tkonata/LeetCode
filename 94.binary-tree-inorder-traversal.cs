/*
 * @lc app=leetcode id=94 lang=csharp
 *
 * [94] Binary Tree Inorder Traversal
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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> tree = new List<int>();
        helper(root, tree);
        return tree;
    }

    private void helper(TreeNode root, IList<int> res) {
        if(root == null)
            return;
        helper(root.left, res);
        res.Add(root.val);
        helper(root.right, res);
    }
}
// @lc code=end

