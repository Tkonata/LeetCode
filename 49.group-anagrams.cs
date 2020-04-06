/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> ans = new List<IList<string>>();
        Dictionary<string, int> res = new Dictionary<string, int>();
        foreach(var item in strs) {
            int[] tmp = new int[26];
            foreach(var ch in item)
                tmp[ch - 'a']++;
            var poStr = string.Join('#', tmp);
            if(res.ContainsKey(poStr))
                ans[res[poStr]].Add(item);
            else {
                res.Add(poStr, ans.Count);
                IList<string> ttmp = new List<string>();
                ttmp.Add(item);
                ans.Add(ttmp);
            }
        }
        return ans;
    }
}
// @lc code=end

