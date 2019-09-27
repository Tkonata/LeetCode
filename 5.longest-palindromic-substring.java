/*
 * @lc app=leetcode id=5 lang=java
 *
 * [5] Longest Palindromic Substring
 */
class Solution {
    public String longestPalindrome(String s) {
        String res = "";
        for (int i = 0; i < s.length(); i++) {
            for (int j = i + 1; j <= s.length(); j++) {
                String sub = s.substring(i, j);
                if (isPalindromic(sub))
                    if (sub.length() > res.length())
                        res = sub;

            }
        }
        return res;
    }

    private boolean isPalindromic(String s) {
        int length = s.length();
        for (int i = 0; i <= length / 2; i++)
            if (s.charAt(i) != s.charAt(length - i - 1))
                return false;
        return true;
    }
}
