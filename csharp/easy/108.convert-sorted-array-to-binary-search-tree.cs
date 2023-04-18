/*
 * @lc app=leetcode id=108 lang=csharp
 *
 * [108] Convert Sorted Array to Binary Search Tree
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
    private int[] _nums;
    public TreeNode SortedArrayToBST(int[] nums) {
        _nums = nums;
        return Recursion(0, _nums.Length - 1);
    }

    private TreeNode Recursion(int left, int right) {
        if(left > right) return null;
        int mid = left + (right - left) / 2;
        var root = new TreeNode(_nums[mid]);
        root.left = Recursion(left, mid - 1);
        root.right = Recursion(mid + 1, right);
        return root;
    }
}
// @lc code=end

