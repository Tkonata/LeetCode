/*
 * @lc app=leetcode id=289 lang=csharp
 *
 * [289] Game of Life
 */

// @lc code=start
public class Solution
{
    int m, n;
    public void GameOfLife(int[][] board) {
        m = board.Length;
        n = board[0].Length;
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)

                Affect(board, i, j);
        foreach(var ea in board) {
            foreach(ref int eb in ea.AsSpan()) {
                var liveCell = eb / 10;
                if(liveCell == 3) eb = 1;
                else if(liveCell == 2 && eb % 10 == 1) eb = 1;
                else eb = 0;
            }
        }
    }
    private void Affect(int[][] board, int i, int j) {
        for(int ix = i - 1; ix <= i + 1; ix++)
            for(int jx = j - 1; jx <= j + 1; jx++) {
                if(ix < 0 || ix >= m || jx < 0 || jx >= n || (i == ix && j == jx) || board[ix][jx] % 10 == 0) continue;
                else board[i][j] += 10;
            }
    }
}
// @lc code=end

