/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution
{
    private string str;
    public string LongestPalindrome(string s) {
        str = s;
        var res = string.Empty;
        for(int i = 0; i < str.Length; i++) {
            var s1 = FindPalindrome(i, i);
            var s2 = FindPalindrome(i, i + 1);
            res = s1.Length > res.Length ? s1 : res;
            res = s2.Length > res.Length ? s2 : res;
        }
        return res;
    }

    public string FindPalindrome(int left, int right) {
        while(left >= 0 && right < str.Length && str[left] == str[right]) {
            left--;
            right++;
        }
        Index start = left + 1;
        return str[start..right];
    }
}
// @lc code=end

