/*
 * @lc app=leetcode id=35 lang=java
 *
 * [35] Search Insert Position
 */
class Solution {
    public int searchInsert(int[] nums, int target) {
        if (nums[nums.length - 1] < target)
            return nums.length;
        if (nums[0] > target)
            return 0;
        int start = 0, end = nums.length - 1;
        while (start < end) {
            int mid = start + (end - start) / 2;
            if (nums[mid] < target)
                start++;
            else if (nums[mid] > target)
                end--;
            else
                return mid;
        }
        return end;
    }
}
