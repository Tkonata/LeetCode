/*
 * @lc app=leetcode id=999 lang=csharp
 *
 * [999] Available Captures for Rook
 */

// @lc code=start
public class Solution
{
    public int NumRookCaptures(char[][] board) {
        var x = 0;
        var y = 0;
        for(int i = 0; i < 8; i++) {
            for(int j = 0; j < 8; j++) {
                if(board[i][j] == 'R') {
                    x = i; y = j;
                    goto aa;
                }
            }
        }
    aa:
        int res = 0;
        for(int i = x - 1; i >= 0; i--) {
            if(board[i][y] == 'p') {
                res++;
                break;
            }
            else if(board[i][y] == 'B')
                break;
        }
        for(int i = x + 1; i < 8; i++) {
            if(board[i][y] == 'p') {
                res++;
                break;
            }
            else if(board[i][y] == 'B')
                break;
        }
        for(int j = y - 1; j >= 0; j--) {
            if(board[x][j] == 'p') {
                res++;
                break;
            }
            else if(board[x][j] == 'B')
                break;
        }
        for(int j = y + 1; j < 8; j++) {
            if(board[x][j] == 'p') {
                res++;
                break;
            }
            else if(board[x][j] == 'B')
                break;
        }
        return res;
    }
}
// @lc code=end

