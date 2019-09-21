/*
 * @lc app=leetcode id=9 lang=java
 *
 * [9] Palindrome Number
 */
class Solution {
    public boolean isPalindrome(int x) {
        if (x < 0)
            return false;
        String s = Integer.toString(x);
        String reverse = new StringBuffer(s).reverse().toString();
        return s.equals(reverse);
    }
}
