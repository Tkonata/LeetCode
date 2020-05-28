/*
 * @lc app=leetcode id=581 lang=cpp
 *
 * [581] Shortest Unsorted Continuous Subarray
 */

// @lc code=start
class Solution {
  public:
    int findUnsortedSubarray(vector<int> &nums) {
        int n = nums.size();
        int left = 0, right = -1;
        int max = nums[0];
        int min = nums[n - 1];
        for(int i = 0; i < n; i++) {
            if(max > nums[i])
                right = i;
            else
                max = nums[i];
            if(min < nums[n - i - 1])
                left = n - i - 1;
            else
                min = nums[n - i - 1];
        }
        return right - left + 1;
    }
};
// @lc code=end

