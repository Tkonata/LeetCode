/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution
{
    public int LengthOfLongestSubstring(string s) {
        int left = 0, right = 0;
        int res = 0;
        var dic = new Dictionary<char, int>();
        for(right = 1; right <= s.Length; right++) {
            var curChar = s[right - 1];
            if(dic.ContainsKey(curChar)) {
                if(dic[curChar] >= left)
                    left = dic[curChar] + 1;
                dic[curChar] = right - 1;
            }
            else {
                dic.Add(curChar, right - 1);
            }
            if(res < right - left)
                res = right - left;
        }
        return res;
    }
}
// @lc code=end

