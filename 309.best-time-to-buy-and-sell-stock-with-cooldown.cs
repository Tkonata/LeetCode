/*
 * @lc app=leetcode id=309 lang=csharp
 *
 * [309] Best Time to Buy and Sell Stock with Cooldown
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices) {
        int dp_i_0 = 0, dp_i_1 = Int32.MinValue;
        int dp_pre_0 = 0;
        for(int i = 0; i < prices.Length; i++) {
            int temp = dp_i_0;
            dp_i_0 = Math.Max(dp_i_0, dp_i_1 + prices[i]);
            dp_i_1 = Math.Max(dp_i_1, dp_pre_0 - prices[i]);
            dp_pre_0 = temp;
        }
        return dp_i_0;
    }
}
// @lc code=end

