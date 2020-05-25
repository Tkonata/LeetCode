/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 */

// @lc code=start
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var len1 = nums1.Length;
        var len2 = nums2.Length;
        var len = len1 + len2;
        int m = 0, n = 0;
        int left = -1, right = -1;
        for(int i = 0; i <= len / 2; i++) {
            left = right;
            if(m < len1 && (n >= len2 || nums1[m] < nums2[n]))
                right = nums1[m++];
            else
                right = nums2[n++];
        }
        if((len & 1) == 0)
            return (left + right) / 2.0;
        else
            return right;
    }
}
// @lc code=end

