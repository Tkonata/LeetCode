/*
 * @lc app=leetcode id=202 lang=csharp
 *
 * [202] Happy Number
 */

// @lc code=start
public class Solution
{
    public bool IsHappy(int n) {
        if(n == 1) return true;
        var set = new HashSet<int>();
        while(!set.Contains(n)) {
            set.Add(n);
            int sum = 0;
            while(n > 0) {
                var tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }
            if(sum == 1) return true;
            n = sum;
        }
        return false;

    }
}
// @lc code=end

