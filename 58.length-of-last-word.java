/*
 * @lc app=leetcode id=58 lang=java
 *
 * [58] Length of Last Word
 */

// @lc code=start
class Solution {
    public int lengthOfLastWord(String s) {
        if (s == null || s.equals(""))
            return 0;
        int res = 0, i = s.length() - 1;
        while (i >= 0 && s.charAt(i) == ' ')
            i--;
        for (; i >= 0; i--) {
            char ch = s.charAt(i);
            if (ch == ' ')
                return res;
            else
                res++;
        }
        return res;
    }
}
// @lc code=end
