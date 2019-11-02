/*
 * @lc app=leetcode id=16 lang=java
 *
 * [16] 3Sum Closest
 */

// @lc code=start
class Solution {
    public int threeSumClosest(int[] nums, int target) {
        int res = nums[0] + nums[1] + nums[2];
        Arrays.sort(nums);
        for (int k = 0; k < nums.length; k++) {
            int i = k + 1, j = nums.length - 1;
            while (i < j) {
                int sum = nums[k] + nums[i] + nums[j];
                int tmp = Math.abs(sum - target);
                if (tmp < Math.abs(res - target)) {
                    res = sum;
                }
                if (sum > target)
                    j--;
                else if (sum < target)
                    i++;
                else
                    return res;

            }
        }
        return res;
    }
}
// @lc code=end
