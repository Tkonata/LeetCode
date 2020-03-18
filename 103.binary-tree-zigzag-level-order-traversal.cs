/*
 * @lc app=leetcode id=103 lang=csharp
 *
 * [103] Binary Tree Zigzag Level Order Traversal
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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        var tmp = new Queue<TreeNode>();
        if(root != null)
            tmp.Enqueue(root);
        bool isPositiveSeq = true;
        while(tmp.Count != 0) {
            var resT = new List<int>();
            var levelLength = tmp.Count;
            for(int i = 0; i < levelLength; i++) {
                var node = tmp.Dequeue();
                if(node.left != null) tmp.Enqueue(node.left);
                if(node.right != null) tmp.Enqueue(node.right);
                resT.Add(node.val);
            }
            if(isPositiveSeq)
                res.Add(resT);
            else {
                resT.Reverse();
                res.Add(resT);
            }
            isPositiveSeq = !isPositiveSeq;
        }
        return res;
    }
}
// @lc code=end

