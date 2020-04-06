/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution
{
    public void MoveZeroes(int[] nums) {
        int i = 0, j = 0;
        for(; j < nums.Length; j++) {
            if(nums[j] != 0) nums[i++] = nums[j];
        }
        for(; i < nums.Length; i++) nums[i] = 0;
    }
}
// @lc code=end

