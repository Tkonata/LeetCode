/*
 * @lc app=leetcode id=26 lang=java
 *
 * [26] Remove Duplicates from Sorted Array
 */
class Solution {
    public int removeDuplicates(int[] nums) {
        if (nums.length == 0)
            return 0;
        int a = nums.length;
        int x = nums[0];
        int j = 1;
        for (int i = 1; i < nums.length; i++) {
            if (nums[i] == x) {
                a--;
            } else {
                x = nums[i];
                nums[j++] = nums[i];
            }
        }
        return a;
    }
}
