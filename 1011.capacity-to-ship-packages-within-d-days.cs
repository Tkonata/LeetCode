/*
 * @lc app=leetcode id=1011 lang=csharp
 *
 * [1011] Capacity To Ship Packages Within D Days
 */

// @lc code=start
public class Solution
{
    public int ShipWithinDays(int[] weights, int D) {
        var left = 0;
        var right = 0;
        foreach(var item in weights) {
            right += item;
            left = Math.Max(left, item);
        }
        while(left < right) {
            var mid = left + (right - left) / 2;
            if(Check(weights, mid, D))
                right = mid;
            else
                left = mid + 1;
        }
        return left;
    }
    private bool Check(int[] weights, int load, int D) {
        int sum = 0;
        foreach(var item in weights) {
            sum += item;
            if(sum > load) {
                D--;
                sum = item;
            }
        }
        return D > 0;
    }
}
// @lc code=end

