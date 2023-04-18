/*
 * @lc app=leetcode id=188 lang=csharp
 *
 * [188] Best Time to Buy and Sell Stock IV
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int k, int[] prices) {
        int n = prices.Length;
        if(n == 0) return 0;
        if(k > n / 2) return MaxProfitKInf(prices);
        var dp = new int[n, k + 1, 2];
        for(int i = 0; i < n; i++) {
            for(int j = k; j > 0; j--) {
                if(i == 0) {
                    dp[0, j, 0] = Math.Max(0, int.MinValue + prices[i]);
                    dp[0, j, 1] = Math.Max(int.MinValue, -prices[i]);
                    continue;
                }
                // dp[i, k, 0] = Math.Max(dp[i - 1, k, 0], dp[i - 1, k, 1] + prices[i])
                dp[i, j, 0] = Math.Max(dp[i - 1, j, 0], dp[i - 1, j, 1] + prices[i]);
                // dp[i, k, 1] = Math.Max(dp[i - 1, k, 1], dp[i - 1, k - 1, 0] - prices[i])
                dp[i, j, 1] = Math.Max(dp[i - 1, j, 1], dp[i - 1, j - 1, 0] - prices[i]);
            }
        }
        return dp[n - 1, k, 0];
    }
    private int MaxProfitKInf(int[] prices) {
        // dp[-1,k,0] = 0
        // dp[-1,k,1] = Int32.MinValue
        // dp[i,0,0] = 0
        // dp[i,0,1] = Int32.MinValue
        int dp_i_0 = 0, dp_i_1 = Int32.MinValue;
        for(int i = 0; i < prices.Length; i++) {
            // dp[i, k, 0] = Math.Max(dp[i - 1, k, 0], dp[i - 1, k, 1] + prices[i])
            dp_i_0 = Math.Max(dp_i_0, dp_i_1 + prices[i]);
            // dp[i, k, 1] = Math.Max(dp[i - 1, k, 1], dp[i - 1, k - 1, 0] - prices[i])
            dp_i_1 = Math.Max(dp_i_1, dp_i_0 - prices[i]);
        }
        return dp_i_0;
    }
}
// @lc code=end

