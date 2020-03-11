/*
 * @lc app=leetcode id=1013 lang=csharp
 *
 * [1013] Partition Array Into Three Parts With Equal Sum
 */

// @lc code=start
public class Solution
{
    public bool CanThreePartsEqualSum(int[] A) {
        var sum = 0;
        Array.ForEach(A, e => sum += e);
        if(sum % 3 != 0)
            return false;
        int tmp = sum / 3;
        int left = 0, right = A.Length - 1;
        int sumL = A[left], sumR = A[right];
        while(left + 1 < right) {
            if(sumL == tmp && sumR == tmp)
                return true;
            if(sumL != tmp)
                sumL += A[++left];
            if(sumR != tmp)
                sumR += A[--right];
        }
        return false;
    }
}
// @lc code=end

