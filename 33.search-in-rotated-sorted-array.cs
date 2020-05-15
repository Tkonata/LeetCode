/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 *
 * solution:https://leetcode-cn.com/problems/search-in-rotated-sorted-array/solution/ji-jian-solution-by-lukelee/
 */

// @lc code=start
public class Solution
{
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length;
        while(left < right) {
            var mid = left + (right - left) / 2;
            if((nums[0] > target) ^ (nums[0] > nums[mid]) ^ (target > nums[mid]))
                left = mid + 1;

            else
                right = mid;
        }
        return left == right && left < nums.Length && nums[left] == target ? left : -1;
    }
}
// @lc code=end

