/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 */

// @lc code=start
public class Solution
{
    public void NextPermutation(int[] nums) {
        var i = nums.Length - 1;
        for(; i > 0; i--)
        {
            if(nums[i - 1] < nums[i])
            {
                int j = i;
                for(; j < nums.Length && nums[j] > nums[i - 1]; j++) ;
                j--;
                var t = nums[j];
                nums[j] = nums[i - 1];
                nums[i - 1] = t;
                break;
            }
        }
        Array.Sort(nums, i, nums.Length - i);
    }
}
// @lc code=end

