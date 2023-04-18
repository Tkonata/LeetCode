/*
 * @lc app=leetcode id=104 lang=csharp
 *
 * [104] Maximum Depth of Binary Tree
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
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        var res = new Queue<TreeNode>();
        var level = 0;
        res.Enqueue(root);
        while(res.Count != 0) {
            int length = res.Count;
            for(int i = 0; i < length; i++) {
                var tmp = res.Dequeue();
                if(tmp.left != null) res.Enqueue(tmp.left);
                if(tmp.right != null) res.Enqueue(tmp.right);
            }
            level++;
        }
        return level;
    }
}
// @lc code=end

