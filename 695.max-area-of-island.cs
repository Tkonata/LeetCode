/*
 * @lc app=leetcode id=695 lang=csharp
 *
 * [695] Max Area of Island
 */

// @lc code=start
public class Solution
{
    int row, col;
    public int MaxAreaOfIsland(int[][] grid) {
    row = grid.Length; col = grid[0].Length;
    int max = 0;
    for(int i = 0; i < row; i++) {
    for(int j = 0; j < col; j++) {
    if(grid[i][j] == 0)
        continue;
    else {
    int res = GetArea(grid, i, j);
    if(res > max)
        max = res;
    }
    }
    }
    return max;
    }
    private int GetArea(int[][] grid, int i, int j) {
    if(i < 0 || i >= row || j < 0 || j >= col) return 0;
    if(grid[i][j] == 0)
        return 0;
    if(grid[i][j] == 1) {
    grid[i][j] = 0;
    var left = GetArea(grid, i, j - 1);
    var right = GetArea(grid, i, j + 1);
    var top = GetArea(grid, i - 1, j);
    var bottom = GetArea(grid, i + 1, j);
    return left + right + top + bottom + 1;
    }
    return 0;
    }
}
// @lc code=end

