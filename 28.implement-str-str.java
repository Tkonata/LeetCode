/*
 * @lc app=leetcode id=28 lang=java
 *
 * [28] Implement strStr()
 */
class Solution {
    public int strStr(String haystack, String needle) {
        if (needle.equals(""))
            return 0;
        int index = -1;
        int length = haystack.length() - needle.length() + 1;
        for (int i = 0; i < length; i++) {
            if (haystack.charAt(i) == needle.charAt(0)) {
                index = i;
                int tmpIndex = 1;
                for (int j = i + 1; j < haystack.length(); j++, tmpIndex++) {
                    if (tmpIndex == needle.length())
                        return index;
                    if (haystack.charAt(j) != needle.charAt(tmpIndex)) {
                        index = -1;
                        break;
                    }
                }
            }
        }
        return index;
    }
}
