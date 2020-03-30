/*
 * @lc app=leetcode id=887 lang=csharp
 *
 * [887] Super Egg Drop
 */

// @lc code=start
public class Solution
{
    Dictionary<(int K, int N), int> memo;
    int[,] dpTable;
    public int SuperEggDrop(int K, int N) {
        //return Recur(K, N);
        return dp(K, N);
    }

    private int Recur(int K, int N) {
        memo = new Dictionary<(int K, int N), int>();
        return RecurHelper(K, N);
    }

    private int RecurHelper(int K, int N) {
        if(K == 1) return N;
        if(N == 0) return 0;
        if(memo.ContainsKey((K, N))) return memo[(K, N)];
        int res = Int32.MaxValue;
        int left = 1, right = N + 1;
        while(left < right) {
            int mid = left + (right - left) / 2;
            var broken = RecurHelper(K - 1, mid - 1);
            var notBroken = RecurHelper(K, N - mid);
            if(broken > notBroken) {
                right = mid;
                res = Math.Min(res, broken + 1);
            }
            else {
                left = mid + 1;
                res = Math.Min(res, notBroken + 1);
            }
        }
        memo.Add((K, N), res);
        return res;
    }

    private int dp(int K, int N) {
        dpTable = new int[K + 1, N + 1];
        for(int i = 0; i < N + 1; i++)
            dpTable[1, i] = i;
        for(int i = 1; i < K + 1; i++)
            dpTable[i, 1] = 1;
        for(int i = 2; i < K + 1; i++) {
            for(int j = 1; j < N + 1; j++) {
                var res = Int32.MaxValue;
                int left = 1, right = j + 1;
                while(left < right) {
                    int mid = left + (right - left) / 2;
                    var broken = dpTable[i - 1, mid - 1];
                    var notBroken = dpTable[i, j - mid];
                    if(broken > notBroken) {
                        right = mid;
                        res = Math.Min(res, broken + 1);
                    }
                    else {
                        left = mid + 1;
                        res = Math.Min(res, notBroken + 1);
                    }
                }
                dpTable[i, j] = res;
            }
        }
        return dpTable[K, N];
    }
}
// @lc code=end

