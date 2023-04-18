/*
 * @lc app=leetcode id=560 lang=csharp
 *
 * [560] Subarray Sum Equals K
 */

// @lc code=start
public class Solution
{
    public int SubarraySum(int[] nums, int k) {
        return UsePerfixSum(nums, k);
    }
    private int UseEnum(int[] nums, int k) {
        var n = nums.Length;
        int ans = 0;
        for(int j = 0; j < n; j++) {
            int res = 0;
            for(int i = j; i >= 0; i--) {
                res += nums[i];
                if(res == k)
                    ans++;
            }
        }
        return ans;
    }

    private int UsePerfixSum(int[] nums, int k) {
        var dic = new Dictionary<int, int>();
        int ans = 0, pre = 0;
        var n = nums.Length;
        dic.Add(0, 1);
        foreach(var item in nums) {
            pre += item;
            if(dic.ContainsKey(pre - k))
                ans += dic[pre - k];
            if(dic.ContainsKey(pre))
                dic[pre]++;
            else
                dic.Add(pre, 1);
        }
        return ans;
    }
}
// @lc code=end

