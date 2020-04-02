/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public class Solution
{
    public int SingleNumber(int[] nums) {
        return UseXOR(nums);
    }

    private int UseSet(int[] nums) {
        var set = new HashSet<int>();
        foreach(var item in nums) {
            if(set.Contains(item))
                set.Remove(item);
            else
                set.Add(item);
        }
        return set.FirstOrDefault();
    }

    private int UseXOR(int[] nums) {
        int res = 0;
        foreach(var item in nums) {
            res ^= item;
        }
        return res;
    }
}
// @lc code=end

