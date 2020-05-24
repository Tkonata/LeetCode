/*
 * @lc app=leetcode id=33 lang=java
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
class Solution {
    public int search(int[] nums, int target) {
        int n=nums.length;
        if(n==0)return -1;
        int left=0,right=n;
        while(left<right){
            int mid=left+(right-left)/2;
            if(nums[mid]==target)return mid;
            if(nums[0]<=nums[mid]){
                if(nums[0]<=target&&target<nums[mid])
                    right=mid;
                else
                    left=mid+1;
            }
            else{
                if(nums[mid]<target&&target<=nums[right-1])
                    left=mid+1;
                else
                    right=mid;
            }
        }
        return -1;
    }
}
// @lc code=end

