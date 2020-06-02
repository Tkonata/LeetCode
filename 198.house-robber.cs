/*
 * @lc app=leetcode id=198 lang=csharp
 *
 * [198] House Robber
 */

// @lc code=start
public class Solution
{
    public int Rob(int[] nums) {
        int n = nums.Length;
        int first = 0, second = 0;
        for(int i = 0; i < n; i++) {
            var temp = Math.Max(second, first + nums[i]);
            first = second;
            second = temp;
        }
        return second;
    }
}
// @lc code=end

