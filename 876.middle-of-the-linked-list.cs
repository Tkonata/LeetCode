/*
 * @lc app=leetcode id=876 lang=csharp
 *
 * [876] Middle of the Linked List
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
public class Solution
{
    public ListNode MiddleNode(ListNode head) {
        ListNode first, second;
        first = head; second = head;
        while(second != null && second.next != null) {
            second = second.next.next;
            first = first.next;
        }
        return first;
    }
}
// @lc code=end

