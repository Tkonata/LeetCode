/*
 * @lc app=leetcode id=1103 lang=csharp
 *
 * [1103] Distribute Candies to People
 */

// @lc code=start
public class Solution
{
    public int[] DistributeCandies(int candies, int num_people) {
        int[] ans = new int[num_people];
        for (int i = 0; i < ans.Length; i++)
        {
            ans[i] = 0;
        }
        int disCount = 1;
        int index = 0;
        while (candies != 0)
        {
            var nowDis = candies < disCount ? candies : disCount;
            ans[index] += nowDis;
            candies -= nowDis;
            index = (index + 1) % num_people;
            disCount++;
        }
        return ans;
    }
}
// @lc code=end

