/*
 * @lc app=leetcode id=96 lang=csharp
 *
 * [96] Unique Binary Search Trees
 */

// @lc code=start
public class Solution
{

    public int NumTrees(int n) {
        return dp(n);
    }

    // g(n) = f(1) + f(2) +...+ f(n)
    // f(i) = g(i-1) * g(n-i)
    private int g(int n) {
        if(n == 0) return 1;
        if(n == 1) return 1;
        int g = 0;
        for(int i = 1; i <= n; i++) {
            g += f(i, n);
        }
        return g;
    }
    private int f(int i, int n) {
        return NumTrees(i - 1) * NumTrees(n - i);
    }

    private int dp(int n) {
        var dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        for(int i = 2; i < n + 1; i++) {
            for(int j = 1; j < i + 1; j++) {
                dp[i] += dp[j - 1] * dp[i - j];
            }
        }
        return dp[n];
    }
}
// @lc code=end

