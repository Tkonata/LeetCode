/*
 * @lc app=leetcode id=435 lang=csharp
 *
 * [435] Non-overlapping Intervals
 */

// @lc code=start
public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals) {
        if(intervals.Length == 0) return 0;
        intervals = intervals.OrderBy(e => e[1]).ToArray();
        int count = 1;
        var x_end = intervals[0][1];
        foreach(var item in intervals) {
            int start = item[0];
            if(start >= x_end) {
                count++;
                x_end = item[1];
            }
        }
        return intervals.Length - count;
    }
}
// @lc code=end

