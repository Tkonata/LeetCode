/*
 * @lc app=leetcode id=714 lang=csharp
 *
 * [714] Best Time to Buy and Sell Stock with Transaction Fee
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices, int fee) {
        int dp_i_0 = 0, dp_i_1 = Int32.MinValue;
        for(int i = 0; i < prices.Length; i++) {
            var temp = dp_i_0;
            dp_i_0 = Math.Max(dp_i_0, dp_i_1 + prices[i]);
            dp_i_1 = Math.Max(dp_i_1, temp - prices[i] - fee);
        }
        return dp_i_0;
    }
}
// @lc code=end

