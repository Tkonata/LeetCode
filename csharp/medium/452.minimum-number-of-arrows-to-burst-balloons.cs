/*
 * @lc app=leetcode id=452 lang=csharp
 *
 * [452] Minimum Number of Arrows to Burst Balloons
 */

// @lc code=start
public class Solution
{
    public int FindMinArrowShots(int[][] points) {
        if(points.Length == 0) return 0;
        points = points.OrderBy(e => e[1]).ToArray();
        int count = 1;
        var x_end = points[0][1];
        foreach(var item in points) {
            int start = item[0];
            if(start > x_end) {
                count++;
                x_end = item[1];
            }
        }
        return count;
    }
}
// @lc code=end

