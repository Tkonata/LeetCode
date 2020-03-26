/*
 * @lc app=leetcode id=892 lang=csharp
 *
 * [892] Surface Area of 3D Shapes
 */

// @lc code=start
public class Solution
{
    public int SurfaceArea(int[][] grid) {
        int n = grid.GetLength(0);
        int area = 0;
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++) {
                var l = grid[i][j];
                if(l > 0) {
                    area += (l << 2) + 2;
                    area -= (i > 0 ? Math.Min(l, grid[i - 1][j]) : 0);
                    area -= (j > 0 ? Math.Min(l, grid[i][j - 1]) : 0);
                    area -= (i < n - 1 ? Math.Min(l, grid[i + 1][j]) : 0);
                    area -= (j < n - 1 ? Math.Min(l, grid[i][j + 1]) : 0);
                }
            }
        }
        return area;
    }
}
// @lc code=end

