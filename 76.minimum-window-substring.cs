/*
 * @lc app=leetcode id=76 lang=csharp
 *
 * [76] Minimum Window Substring
 */

// @lc code=start
public class Solution {
    public string MinWindow(string s, string t) {
        int resStart = 0, minLength = Int32.MaxValue;
        int left = 0, right = 0;
        var window = new Dictionary<char, int>();
        var need = new Dictionary<char, int>();
        int match = 0;
        foreach(var ch in t)
            if(need.ContainsKey(ch))
                need[ch]++;
            else need.Add(ch, 1);

        while(right < s.Length) {
            var ch = s[right];
            if(need.ContainsKey(ch)) {
                if(window.ContainsKey(ch))
                    window[ch]++;
                else window.Add(ch, 1);
                if(window[ch] == need[ch]) {
                    match++;
                }
            }
            right++;
            while(match == need.Count) {
                if(right - left < minLength) {
                    resStart = left;
                    minLength = right - left;
                }
                char ch2 = s[left];
                if(need.ContainsKey(ch2)) {
                    window[ch2]--;
                    if(window[ch2] < need[ch2])
                        match--;
                }
                left++;
            }
        }
        return minLength == Int32.MaxValue ? "" : s.Substring(resStart, minLength);
    }
}
// @lc code=end

