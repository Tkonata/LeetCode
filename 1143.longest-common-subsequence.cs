/*
 * @lc app=leetcode id=1143 lang=csharp
 *
 * [1143] Longest Common Subsequence
 */

// @lc code=start
public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2) {
        return dpTable(text1, text2);
    }

    // 递归方法, 超时
    private int dpRecursion(string str1, string str2) {
        if(str1 == string.Empty || str2 == string.Empty)
            return 0;
        int i = str1.Length, j = str2.Length;
        if(str1[i - 1] == str2[j - 1])
            return dpRecursion(str1.Substring(0, i - 1), str2.Substring(0, j - 1)) + 1;
        else
            return Math.Max(dpRecursion(str1.Substring(0, i - 1), str2), dpRecursion(str1, str2.Substring(0, j - 1)));
    }

    // 状态转移方程
    //          0, i=0 or j=0
    // dp[i,j]= dp[i-1,j-1]+1, text1[i]=text2[j]
    //          max(dp[i,j-1],dp[i-1,j])
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

