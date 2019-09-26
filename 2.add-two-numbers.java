/*
 * @lc app=leetcode id=2 lang=java
 *
 * [2] Add Two Numbers
 */
/**
 * Definition for singly-linked list. public class ListNode { int val; ListNode
 * next; ListNode(int x) { val = x; } }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        ListNode p = l1, q = l2;
        boolean carry = false;
        while (p.next != null && q.next != null) {
            p.val += q.val;
            if (carry) {
                p.val++;
                carry = false;
            }
            if (p.val > 9) {
                carry = true;
                p.val -= 10;
            }
            p = p.next;
            q = q.next;
        }
        if (q.next != null && p.next == null) {
            p.next = q.next;
            p.val += q.val;
            if (carry) {
                p.val++;
                carry = false;
            }
            if (p.val > 9) {
                p.val -= 10;
                carry = true;
            }

        } else if (q.next == null && p.next == null) {
            p.val += q.val;
            if (carry) {
                p.val++;
            }
            if (p.val > 9) {
                p.val -= 10;
                p.next = new ListNode(1);
            }
            return l1;
        } else {
            p.val += q.val;
            if (carry) {
                p.val++;
                carry = false;
            }
            if (p.val > 9) {
                p.val -= 10;
                carry = true;
            }

        }
        p = p.next;
        while (p.next != null) {
            if (carry) {
                p.val++;
                carry = false;
            } else
                return l1;
            if (p.val > 9) {
                carry = true;
                p.val -= 10;
            }
            p = p.next;
        }
        if (carry) {
            p.val++;
        }
        if (p.val > 9) {
            p.val -= 10;
            p.next = new ListNode(1);
        }
        return l1;
    }
}
