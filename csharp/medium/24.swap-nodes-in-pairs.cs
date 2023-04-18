/*
 * @lc app=leetcode id=24 lang=csharp
 *
 * [24] Swap Nodes in Pairs
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        return Recurse(head);
    }

    private ListNode Recurse(ListNode head) {
        if (head == null || head.next == null)
            return head;
        else {
            var temp = head.next.next;
            head.next.next = head;
            head = head.next;
            head.next.next = Recurse(temp);
            return head;
        }
    }

}
// @lc code=end

