/*
 * @lc app=leetcode id=123 lang=csharp
 *
 * [123] Best Time to Buy and Sell Stock III
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices) {
        if(prices.Length == 0) return 0;
        // dp[-1,k,0] = 0
        // dp[-1,k,1] = Int32.MinValue
        // dp[i,0,0] = 0
        // dp[i,0,1] = Int32.MinValue
        //int dp_i_0 = 0, dp_i_1 = Int32.MinValue;
        int n = prices.Length;
        if(n == 0) return 0;
        var dp = new int[n, 3, 2];
        for(int i = 0; i < n; i++) {
            for(int k = 2; k > 0; k--) {
                if(i == 0) {
                    dp[0, k, 0] = Math.Max(0, int.MinValue + prices[i]);
                    dp[0, k, 1] = Math.Max(int.MinValue, -prices[i]);
                    continue;
                }
                // dp[i, k, 0] = Math.Max(dp[i - 1, k, 0], dp[i - 1, k, 1] + prices[i])
                dp[i, k, 0] = Math.Max(dp[i - 1, k, 0], dp[i - 1, k, 1] + prices[i]);
                // dp[i, k, 1] = Math.Max(dp[i - 1, k, 1], dp[i - 1, k - 1, 0] - prices[i])
                dp[i, k, 1] = Math.Max(dp[i - 1, k, 1], dp[i - 1, k - 1, 0] - prices[i]);
            }
        }
        return dp[n - 1, 2, 0];
    }
}
// @lc code=end

