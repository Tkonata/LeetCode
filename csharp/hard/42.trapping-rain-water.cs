/*
 * @lc app=leetcode id=42 lang=csharp
 *
 * [42] Trapping Rain Water
 */

// @lc code=start
public class Solution
{
    public int Trap(int[] height) {
        if(height.Length == 0)
            return 0;
        var n = height.Length;
        var ans = 0;
        var lMax = height[0];
        var rMax = height[n - 1];
        var left = 0;
        var right = n - 1;
        while(left <= right) {
            lMax = Math.Max(lMax, height[left]);
            rMax = Math.Max(rMax, height[right]);
            if(lMax < rMax) {
                ans += lMax - height[left];
                left++;
            }
            else {
                ans += rMax - height[right];
                right--;
            }
        }
        return ans;
    }

    public int Memo(int[] height) {
        if(height.Length == 0)
            return 0;
        var n = height.Length;
        var ans = 0;
        var lMax = new int[n];
        var rMax = new int[n];
        lMax[0] = height[0];
        rMax[n - 1] = height[n - 1];
        for(int i = 1; i < n; i++)
            lMax[i] = Math.Max(height[i], lMax[i - 1]);
        // 从右向左计算 r_max
        for(int i = n - 2; i >= 0; i--)
            rMax[i] = Math.Max(height[i], rMax[i + 1]);
        // 计算答案
        for(int i = 1; i < n - 1; i++)
            ans += Math.Min(lMax[i], rMax[i]) - height[i];
        return ans;
    }
}
// @lc code=end

