/*
 * @lc app=leetcode id=21 lang=java
 *
 * [21] Merge Two Sorted Lists
 */
/**
 * Definition for singly-linked list. public class ListNode { int val; ListNode
 * next; ListNode(int x) { val = x; } }
 */
class Solution {
    public ListNode mergeTwoLists(ListNode l1, ListNode l2) {
        ListNode res, tmp;
        if (l1.val > l2.val) {
            res = l2;
            tmp = l1;
        } else {
            res = l1;
            tmp = l2;
        }
        ListNode p = res;
        while (tmp.next != null) {
            if (tmp.val < p.next.val && tmp.val >= p.val) {
                ListNode t = tmp;
                tmp = tmp.next;
                t.next = p.next;
                p.next = t;
            } else
                p = p.next;

        }
        return res;
    }
}
