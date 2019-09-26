import java.util.HashSet;

/*
 * @lc app=leetcode id=3 lang=java
 *
 * [3] Longest Substring Without Repeating Characters
 */
class Solution {
    public int lengthOfLongestSubstring(String s) {
        int le = s.length();
        int res = 0, i = 0, j = 0;
        HashSet<Character> set = new HashSet<>();
        while (i < le && j < le) {
            if (set.contains(s.charAt(j))) {
                set.remove(s.charAt(i++));
            } else {
                set.add(s.charAt(j++));
                res = res > (j - i) ? res : j - i;
            }
        }
        return res;
    }
}
