/*
 * @lc app=leetcode id=31 lang=csharp
 *
 * [31] Next Permutation
 */

// @lc code=start
public class Solution
{
    public void NextPermutation(int[] nums) {
        int maxPoint = 0;
        for(int i = nums.Length - 1; i > 0; i--) {
            if(nums[i - 1] < nums[i]) {
                maxPoint = i;
                var exchangeIndex = 0;
                for(int j = nums.Length - 1; j >= maxPoint; j--) {
                    if(nums[j] > nums[maxPoint - 1]) {
                        exchangeIndex = j;
                        break;
                    }
                }
                var tmp = nums[maxPoint - 1];
                nums[maxPoint - 1] = nums[exchangeIndex];
                nums[exchangeIndex] = tmp;
                break;
            }
        }
        int left = maxPoint, right = nums.Length - 1;
        while(left < right) {
            var tmp = nums[left];
            nums[left] = nums[right];
            nums[right] = tmp;
            left++;
            right--;
        }
    }
}
// @lc code=end

