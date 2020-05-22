/*
 * @lc app=leetcode id=1010 lang=csharp
 *
 * [1010] Pairs of Songs With Total Durations Divisible by 60
 */

// @lc code=start
public class Solution
{
    public int NumPairsDivisibleBy60(int[] time) {
        int[] remainder = new int[60];
        foreach(var item in time) {
            remainder[item % 60]++;
        }
        int i = 1;
        int j = 59;
        int ans = 0;
        while(i < j) {
            ans += remainder[i] * remainder[j];
            i++;
            j--;
        }
        ans += Helper(remainder[0]) + Helper(remainder[30]);
        return ans;
    }
    private int Helper(int n) => n * (n - 1) / 2;
}
// @lc code=end

