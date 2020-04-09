/*
 * @lc app=leetcode id=22 lang=csharp
 *
 * [22] Generate Parentheses
 */

// @lc code=start
public class Solution {
    private IList<string> ans;

    private StringBuilder curStr;
    public IList<string> GenerateParenthesis(int n) {
        ans = new List<string>();
        curStr = new StringBuilder();
        dfs(n, n);
        return ans;
    }

    private void dfs(int left, int right) {
        if(left == 0 && right == 0) {
            ans.Add(curStr.ToString());
            return;
        }
        if(left > right)
            return;
        if(left > 0) {
            curStr.Append('(');
            dfs(left - 1, right);
            curStr.Remove(curStr.Length - 1, 1);
        }
        if(right > left) {
            curStr.Append(')');
            dfs(left, right - 1);
            curStr.Remove(curStr.Length - 1, 1);
        }
    }
}
// @lc code=end

