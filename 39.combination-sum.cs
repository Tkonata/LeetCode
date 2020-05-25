/*
 * @lc app=leetcode id=39 lang=csharp
 *
 * [39] Combination Sum
 */

// @lc code=start
public class Solution
{
    private IList<int> now;
    private IList<IList<int>> ans;
    private int sum;
    private int[] _cand;
    private int _target;
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        now = new List<int>();
        ans = new List<IList<int>>();
        sum = 0;
        _cand = candidates;
        _target = target;
        Backtrack(0);
        return ans;
    }

    public void Backtrack(int i) {
        if(sum == _target) {
            ans.Add(now);
            now = now.ToList();
            return;
        }
        if(sum > _target)
            return;
        for(int k = i; k < _cand.Length; k++) {
            now.Add(_cand[k]);
            sum += _cand[k];
            Backtrack(k);
            sum -= _cand[k];
            now.RemoveAt(now.Count - 1);
        }
    }
}
// @lc code=end

