/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums) {
        if(nums == null || nums.Length < 3)
            return new List<IList<int>>(0);
        var ans = new List<IList<int>>();
        Array.Sort(nums);
        int n = nums.Length;
        for(int i = 0; i < n && nums[i] <= 0; i++) {
            if(i > 0 && nums[i] == nums[i - 1])
                continue;
            int left = i + 1;
            int right = n - 1;
            while(left < right) {
                var tmp = nums[i] + nums[left] + nums[right];
                if(tmp == 0) {
                    ans.Add(new List<int> { nums[i], nums[left], nums[right] });
                    while(left < right && nums[left] == nums[left + 1])
                        left++;
                    while(left < right && nums[right] == nums[right - 1])
                        right--;
                    left++;
                    right--;
                }
                else if(tmp > 0)
                    right--;
                else
                    left++;
            }
        }
        return ans;
    }
}
// @lc code=end

