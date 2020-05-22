/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            var tmp = target - nums[i];
            if(dic.ContainsKey(tmp))
                return new int[] { dic[tmp], i };
            else {
                if(!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
        }
        return new int[0];
    }
}
// @lc code=end

