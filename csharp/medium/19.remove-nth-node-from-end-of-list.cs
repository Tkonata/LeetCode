/*
 * @lc app=leetcode id=19 lang=csharp
 *
 * [19] Remove Nth Node From End of List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var dummy = new ListNode(0);
        dummy.next = head;
        var q = dummy;
        for(int i = 0; i < n; i++) {
            q = q.next;
        }
        var p = dummy;
        while(q.next != null) {
            p = p.next;
            q = q.next;
        }
        p.next = p.next.next;
        return dummy.next;
    }
}
// @lc code=end

