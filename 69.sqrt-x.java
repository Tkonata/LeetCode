/*
 * @lc app=leetcode id=69 lang=java
 *
 * [69] Sqrt(x)
 */

// @lc code=start
class Solution {
    public int mySqrt(int x) {
        long left = 0;
        long right = x / 2 + 1;
        while (left < right) {
            long mid = (left + right + 1) >>> 1;
            long pows = mid * mid;
            if (pows > x)
                right = mid - 1;
            else
                left = mid;
        }
        return (int) left;
    }
}
// @lc code=end
