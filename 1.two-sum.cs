/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++) {
            var tmp = target - nums[i];
            if(dic.ContainsKey(tmp))
                return new int[] { dic[tmp], i };
            else {
                if(!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }
        }
        return new int[0];
    }

    public int[] TwoPointer(int[] nums, int target) {
        int[] numsCopy = new int[nums.Length];
        Array.Copy(nums, numsCopy, nums.Length);
        Array.Sort(numsCopy);
        var left = 0;
        var right = numsCopy.Length - 1;
        while(left < right) {
            var ans = numsCopy[left] + numsCopy[right];
            if(ans == target)
                break;
            else if(ans > target)
                right--;
            else
                left++;
        }
        if(left == right)
            return new int[0];
        var lFlag = false;
        var rFlag = false;
        var ansLeft = 0;
        var ansRight = 0;
        for(int i = 0; i < nums.Length; i++) {
            if(nums[i] == numsCopy[left] && !lFlag) {
                ansLeft = i;
                lFlag = true;
            }
            else if(nums[i] == numsCopy[right] && !rFlag) {
                ansRight = i;
                rFlag = true;
            }
        }
        if(ansLeft > ansRight)
            return new int[] { ansRight, ansLeft };
        else
            return new int[] { ansLeft, ansRight };
    }
}
// @lc code=end

