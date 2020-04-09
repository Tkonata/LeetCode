/*
 * @lc app=leetcode id=48 lang=csharp
 *
 * [48] Rotate Image
 */

// @lc code=start
public class Solution
{
    public void Rotate(int[][] matrix) {
        var n = matrix.Length;
        if(n == 0)
            return;
        int r = n >> 1;
        int c = (n + 1) >> 1;
        for(int i = 0; i < r; i++) {
            for(int j = 0; j < c; j++) {
                swap(ref matrix[i][j], ref matrix[j][n - 1 - i]);
                swap(ref matrix[i][j], ref matrix[n - 1 - i][n - 1 - j]);
                swap(ref matrix[i][j], ref matrix[n - j - 1][i]);
            }
        }
    }

    private void swap(ref int a, ref int b) {
        var temp = a;
        a = b;
        b = temp;
    }
}
// @lc code=end

