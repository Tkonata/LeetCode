/*
 * @lc app=leetcode id=27 lang=java
 *
 * [27] Remove Element
 */
class Solution {
    public int removeElement(int[] nums, int val) {
        int le = nums.length;
        int step = 0;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == val) {
                le--;
                step++;
            } else
                nums[i - step] = nums[i];
        }
        return le;
    }
}
