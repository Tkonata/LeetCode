/*
 * @lc app=leetcode id=322 lang=csharp
 *
 * [322] Coin Change
 */

// @lc code=start
public class Solution
{
    int[] memo;
    public int CoinChange(int[] coins, int amount) {
        if(coins.Length == 0)
            return -1;
        memo = new int[amount];
        return FindWay(coins, amount);
    }

    private int FindWay(int[] coins, int amount) {
        if(amount < 0)
            return -1;
        if(amount == 0)
            return 0;
        if(memo[amount - 1] != 0)
            return memo[amount - 1];

        int min = Int32.MaxValue;
        for(int i = 0; i < coins.Length; i++) {
            int res = FindWay(coins, amount - coins[i]);
            if(res >= 0 && res < min)
                min = res + 1;
        }
        memo[amount - 1] = min == Int32.MaxValue ? -1 : min;
        return memo[amount - 1];
    }
}
// @lc code=end

