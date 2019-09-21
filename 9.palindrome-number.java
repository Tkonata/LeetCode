/*
 * @lc app=leetcode id=9 lang=java
 *
 * [9] Palindrome Number
 */
class Solution {
    /*
     * study the solution
     * https://leetcode.com/problems/palindrome-number/discuss/319913/Java-runtime-
     * 6ms-faster-than-100
     */
    public boolean isPalindrome(int x) {
        if (x < 0)
            return false;
        int reverse = 0, tmp = x;
        while (tmp > 0) {
            reverse = reverse * 10;
            reverse += tmp % 10;
            tmp /= 10;
        }
        return reverse == x;
    }
}
