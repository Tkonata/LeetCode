/*
 * @lc app=leetcode id=113 lang=csharp
 *
 * [113] Path Sum II
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
    IList<IList<int>> res;
    LinkedList<int> temp;
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        res = new List<IList<int>>();
        temp = new LinkedList<int>();
        Recur(root, sum);
        return res;
    }
    private void Recur(TreeNode root, int sum) {
        if(root == null) return;
        if(root.left == null && root.right == null) {
            if(sum == root.val) {
                temp.AddLast(root.val);
                res.Add(temp.ToList());
                temp.RemoveLast();
            }
            return;
        }
        temp.AddLast(root.val);
        Recur(root.left, sum - root.val);
        Recur(root.right, sum - root.val);
        temp.RemoveLast();
        return;
    }
}
// @lc code=end

