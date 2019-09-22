/*
 * @lc app=leetcode id=14 lang=java
 *
 * [14] Longest Common Prefix
 */
class Solution {
    public String longestCommonPrefix(String[] strs) {
        if (strs == null || strs.length == 0)
            return "";
        String result = strs[0];
        for (int i = 0; i < strs[0].length(); i++) {
            String subStr = result.substring(0, result.length() - i);
            int j = 1;
            for (; j < strs.length; j++) {
                if (strs[j].startsWith(subStr))
                    continue;
                else
                    break;
            }
            if (j == strs.length)
                return subStr;
        }
        return "";
    }
}
