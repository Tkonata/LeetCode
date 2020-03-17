/*
 * @lc app=leetcode id=101 lang=csharp
 *
 * [101] Symmetric Tree
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
    public bool IsSymmetric(TreeNode root) {
        if(root == null) return true;
        // return Recursion(root.left, root.right);
        return Iteration(root);
    }

    private bool Recursion(TreeNode left, TreeNode right) {
        if(left == null && right == null) return true;
        if(left == null || right == null) return false;
        if(left.val == right.val) {
            return Recursion(left.left, right.right) && Recursion(left.right, right.left);
        }
        else
            return false;
    }

    private bool Iteration(TreeNode root) {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);
        while(queue.Count != 0) {
            var a = queue.Dequeue();
            var b = queue.Dequeue();
            if(a == null && b == null) continue;
            if(a == null || b == null) return false;
            if(a.val == b.val) {
                queue.Enqueue(a.left);
                queue.Enqueue(b.right);
                queue.Enqueue(a.right);
                queue.Enqueue(b.left);
            }
            else
                return false;
        }
        return true;
    }
}
// @lc code=end

