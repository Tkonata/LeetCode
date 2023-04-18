/*
 * @lc app=leetcode id=945 lang=csharp
 *
 * [945] Minimum Increment to Make Array Unique
 */

// @lc code=start
public class Solution
{
    public int MinIncrementForUnique(int[] A) {
        Array.Sort(A);
        var res = 0;
        for(int i = 1; i < A.Length; i++) {
            if(A[i] == A[i - 1]) {
                A[i]++;
                res++;
            }
            if(A[i] < A[i - 1]) {
                res += A[i - 1] - A[i] + 1;
                A[i] = A[i - 1] + 1;
            }
        }
        return res;
    }
}
// @lc code=end

