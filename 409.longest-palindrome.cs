/*
 * @lc app=leetcode id=409 lang=csharp
 *
 * [409] Longest Palindrome
 */

// @lc code=start
public class Solution
{
    public int LongestPalindrome(string s) {
        var alphabet = new Dictionary<char, int>();
        foreach(var ch in s) {
            if(alphabet.ContainsKey(ch))
                alphabet[ch]++;
            else
                alphabet.Add(ch, 1);
        }
        bool isCenter = false;
        int res = 0;
        foreach(var item in alphabet) {
            if(item.Value % 2 == 0)
                res += item.Value;
            else {
                var temp = item.Value / 2;
                res += 2 * temp;
                if(!isCenter) {
                    res += 1;
                    isCenter = true;
                }

            }
        }
        return res;
    }
}
// @lc code=end

