/*
 * @lc app=leetcode id=32 lang=csharp
 *
 * [32] Longest Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public int LongestValidParentheses(string s) {
        if(s == string.Empty)
            return 0;
        var dp = new int[s.Length];
        dp[0] = 0;
        for(int i = 1; i < s.Length; i++) {
            var ch = s[i];
            if(ch == ')') {
                if(s[i - 1] == '(') {
                    if(i > 1)
                        dp[i] = 2 + dp[i - 2];
                    else
                        dp[i] = 2;
                }
                else if(dp[i - 1] > 0) {
                    var leftIndex = i - 1 - dp[i - 1];
                    if(leftIndex >= 0) {
                        if(s[leftIndex] == '(')
                            if(leftIndex - 1 >= 0)
                                dp[i] = 2 + dp[i - 1] + dp[leftIndex - 1];
                            else
                                dp[i] = dp[i - 1] + 2;
                    }
                }
            }
        }
        return dp.Max();
    }
}
// @lc code=end

