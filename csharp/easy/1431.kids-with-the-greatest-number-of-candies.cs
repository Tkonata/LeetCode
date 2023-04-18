/*
 * @lc app=leetcode id=1431 lang=csharp
 *
 * [1431] Kids With the Greatest Number of Candies
 */

// @lc code=start
public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var n = candies.Length;
        var max = candies.Max();
        var ans = new List<bool>(n);
        foreach(var item in candies) {
            ans.Add(item + extraCandies >= max);
        }
        return ans;
    }
}
// @lc code=end

