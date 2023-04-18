/*
 * @lc app=leetcode id=10 lang=csharp
 *
 * [10] Regular Expression Matching
 */

// @lc code=start
public class Solution
{
    public bool IsMatch(string s, string p) {
        if(s == null || p == null) return false;
        int m = s.Length; int n = p.Length;
        bool[,] dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;
        for(int i = 2; i < n + 1; i++)
            if(p[i - 1] == '*' && dp[0, i - 2])
                dp[0, i] = true;
        for(int i = 1; i < m + 1; i++) {
            for(int j = 1; j < n + 1; j++) {
                if(j >= 2 && p[j - 1] == '*') {
                    bool t1 = dp[i - 1, j] && (p[j - 2] == s[i - 1] || p[j - 2] == '.');
                    bool t2 = dp[i, j - 2];
                    dp[i, j] = t1 || t2;
                }
                else if(p[j - 1] == '.' || p[j - 1] == s[i - 1]) {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else {
                    dp[i, j] = false;
                }
            }
        }
        return dp[m, n];
    }
}
// @lc code=end

