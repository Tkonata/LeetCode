/*
 * @lc app=leetcode id=1035 lang=csharp
 *
 * [1035] Uncrossed Lines
 */

// @lc code=start
public class Solution
{
    public int MaxUncrossedLines(int[] A, int[] B) {
        dpTable(A, B);
    }

    private int dpTable(string text1, string text2) {
        int m = text1.Length, n = text2.Length;
        var dp = new int[m + 1, n + 1];
        for(int i = 0; i < m + 1; i++) {
            for(int j = 0; j < n + 1; j++) {
                if(i == 0 || j == 0) {
                    dp[i, j] = 0;
                    continue;
                }
                if(text1[i - 1] == text2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
            }
        }
        return dp[m, n];
    }
}
// @lc code=end

