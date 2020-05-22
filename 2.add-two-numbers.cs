/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var p = l1;
        var q = l2;
        var pre = l1;
        bool carry = false;
        while(p != null && q != null) {
            p.val += q.val;
            if(carry) {
                p.val++;
                carry = false;
            }
            if(p.val > 9) {
                carry = true;
                p.val -= 10;
            }
            pre = p;
            p = p.next;
            q = q.next;
        }
        if(p == null && q == null) {
            if(carry)
                pre.next = new ListNode(1);
            return l1;
        }
        if(p == null) {
            pre.next = q;
            p = pre.next;
        }
        if(carry) {
            while(p != null) {
                p.val++;
                if(p.val > 9)
                    p.val -= 10;
                else
                    break;
                pre = p;
                p = p.next;
            }
            if(p == null)
                pre.next = new ListNode(1);
        }
        return l1;
    }
}
// @lc code=end

