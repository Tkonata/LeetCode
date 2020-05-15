/*
 * @lc app=leetcode id=239 lang=csharp
 *
 * [239] Sliding Window Maximum
 */

// @lc code=start
public class Solution
{
    private LinkedList<int> data;
    private List<int> ans;
    public int[] MaxSlidingWindow(int[] nums, int k) {
        data = new LinkedList<int>();
        ans = new List<int>();
        for(int i = 0; i < nums.Length; i++) {
            if(i < k - 1)
                Push(nums[i]);
            else {
                Push(nums[i]);
                ans.Add(Max());
                Pop(nums[i - k + 1]);
            }
        }
        return ans.ToArray();
    }

    private void Push(int n) {
        while(data.Count != 0 && data.Last.Value < n)
            data.RemoveLast();
        data.AddLast(n);
    }

    private int Max() {
        return data.First.Value;
    }

    private void Pop(int n) {
        if(data.Count != 0 && Max() == n)
            data.RemoveFirst();
    }
}
// @lc code=end

