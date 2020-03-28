/*
 * @lc app=leetcode id=72 lang=csharp
 *
 * [72] Edit Distance
 */

// @lc code=start
public class Solution
{
    private string s1;
    private string s2;

    private int[,] dp;
    public int MinDistance(string word1, string word2) {
        s1 = word1; s2 = word2;
        //dp = new int[s1.Length + 1, s2.Length + 1];
        //return Recur(s1.Length - 1, s2.Length - 1);
        return dpTable();
    }

    private int Recur(int i, int j) {
        if(i == -1) {
            dp[i + 1, j + 1] = j + 1;
            return dp[i + 1, j + 1];
        }
        if(j == -1) {
            dp[i + 1, j + 1] = i + 1;
            return dp[i + 1, j + 1];
        }
        if(dp[i + 1, j + 1] != 0) return dp[i + 1, j + 1];
        if(s1[i] == s2[j])
            dp[i + 1, j + 1] = Recur(i - 1, j - 1);
        else {
            var a1 = Recur(i, j - 1);
            var a2 = Recur(i - 1, j);
            var a3 = Recur(i - 1, j - 1);
            int[] tmpRes = new int[3] { a1, a2, a3 };
            dp[i + 1, j + 1] = tmpRes.Min() + 1;
        }
        return dp[i + 1, j + 1];
    }

    private int dpTable() {
        int m = s1.Length; int n = s2.Length;
        dp = new int[m + 1, n + 1];
        for(int i = 0; i <= m; i++)
            dp[i, 0] = i;
        for(int j = 0; j <= n; j++)
            dp[0, j] = j;
        for(int i = 1; i <= m; i++) {
            for(int j = 1; j <= n; j++) {
                if(s1[i - 1] == s2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1];
                else {
                    int[] tmpRes = new int[3] { dp[i, j - 1], dp[i - 1, j], dp[i - 1, j - 1] };
                    dp[i, j] = tmpRes.Min() + 1;
                }
            }
        }
        return dp[m, n];
    }
}
// @lc code=end

