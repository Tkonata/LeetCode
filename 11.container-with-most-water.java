/*
 * @lc app=leetcode id=11 lang=java
 *
 * [11] Container With Most Water
 */
class Solution {
    public int maxArea(int[] height) {
        int i = 0, j = height.length - 1;
        int res = Math.min(height[i], height[j]) * (j - i);
        while (i < j) {
            if (height[i] < height[j])
                i++;
            else
                j--;
            int tmp = Math.min(height[i], height[j]) * (j - i);
            if (tmp > res)
                res = tmp;
        }
        return res;
    }
}
