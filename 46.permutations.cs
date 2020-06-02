/*
 * @lc app=leetcode id=46 lang=csharp
 *
 * [46] Permutations
 */

// @lc code=start
public class Solution
{
    HashSet<int> set;
    IList<IList<int>> ans;
    IList<int> now;
    int[] _nums;
    public IList<IList<int>> Permute(int[] nums) {
        set = new HashSet<int>(nums.Length);
        ans = new List<IList<int>>();
        _nums = nums;
        now = new List<int>();
        RecurHelper();
        return ans;
    }

    private void RecurHelper() {
        if(set.Count == _nums.Length) {
            ans.Add(now);
            now = now.ToList();
        }
        foreach(var item in _nums) {
            if(!set.Contains(item)) {
                set.Add(item);
                now.Add(item);
                RecurHelper();
                set.Remove(item);
                now.Remove(item);
            }
        }
    }
}
// @lc code=end

