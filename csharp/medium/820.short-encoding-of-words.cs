/*
 * @lc app=leetcode id=820 lang=csharp
 *
 * [820] Short Encoding of Words
 */

// @lc code=start
public class Solution
{
    public int MinimumLengthEncoding(string[] words) {
        var set = new HashSet<string>();
        Array.ForEach(words, e => set.Add(e));
        int n = set.Count + 1;
        var tmp = new HashSet<string>();
        foreach(var item in set) {
            for(int i = 1; i < item.Length; i++) {
                if(set.Contains(item.Substring(i)))
                    tmp.Add(item.Substring(i));
            }
        }
        foreach(var item in tmp) set.Remove(item);
        int res = 0;
        foreach(var item in set) res += item.Length + 1;
        return res;
    }
}
// @lc code=end

