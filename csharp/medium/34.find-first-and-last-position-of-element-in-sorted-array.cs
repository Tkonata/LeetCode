/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */

// @lc code=start
public class Solution
{
    public int[] SearchRange(int[] nums, int target) {
        var left = LeftBound(nums, target);
        var right = RightBound(nums, target);
        return new int[] { left, right };
    }

    private int LeftBound(int[] nums, int target) {
        var left = 0;
        var right = nums.Length;
        while(left < right) {
            var mid = left + (right - left) / 2;
            if(nums[mid] == target)
                right = mid;
            else if(nums[mid] < target)
                left = mid + 1;
            else
                right = mid;
        }
        if(left >= nums.Length || nums[left] != target)
            return -1;
        return left;
    }
    private int RightBound(int[] nums, int target) {
        if(nums.Length == 0)
            return -1;
        var left = 0;
        var right = nums.Length;
        while(left < right) {
            var mid = left + (right - left) / 2;
            if(nums[mid] == target)
                left = mid + 1;
            else if(nums[mid] < target)
                left = mid + 1;
            else
                right = mid;
        }
        if(left <= 0 || nums[left - 1] != target)
            return -1;
        return left - 1;
    }
}
// @lc code=end

