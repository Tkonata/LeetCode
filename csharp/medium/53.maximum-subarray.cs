/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution
{
    public int MaxSubArray(int[] nums) {
        int ans = nums[0];
        int sum = 0;
        foreach(var item in nums) {
            if(sum > 0) {
                sum += item;
            }
            else { sum = item; }
            ans = Math.Max(ans, sum);
        }
        return ans;
    }
}
// @lc code=end

