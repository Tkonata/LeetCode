/*
 * @lc app=leetcode id=28 lang=java
 *
 * [28] Implement strStr()
 */
class Solution {
    public int strStr(String haystack, String needle) {
        if (needle.equals(""))
            return 0;
        if (needle.length() > haystack.length())
            return -1;
        int indexNeedle = 0;
        int index = -1;
        for (int i = 0; i < haystack.length(); i++) {
            if (haystack.charAt(i) == needle.charAt(indexNeedle)) {
                if (index == -1)
                    index = i;
                indexNeedle++;
                if (indexNeedle == needle.length())
                    return index;
            } else {
                index = -1;
                indexNeedle = 0;
            }
        }
        return -1;
    }
}
