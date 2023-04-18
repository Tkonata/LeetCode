/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices) {
        // dp[-1,k,0] = 0
        // dp[-1,k,1] = Int32.MinValue
        // dp[i,0,0] = 0
        // dp[i,0,1] = Int32.MinValue
        int dp_i_0 = 0, dp_i_1 = Int32.MinValue;
        for(int i = 0; i < prices.Length; i++) {
            // dp[i, k, 0] = Math.Max(dp[i - 1, k, 0], dp[i - 1, k, 1] + prices[i])
            dp_i_0 = Math.Max(dp_i_0, dp_i_1 + prices[i]);
            // dp[i, k, 1] = Math.Max(dp[i - 1, k, 1], dp[i - 1, k - 1, 0] - prices[i])
            dp_i_1 = Math.Max(dp_i_1, -prices[i]);
        }
        return dp_i_0;
    }
}
// @lc code=end

