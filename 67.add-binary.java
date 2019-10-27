/*
 * @lc app=leetcode id=67 lang=java
 *
 * [67] Add Binary
 */

// @lc code=start
class Solution {
    public String addBinary(String a, String b) {
        StringBuilder sb = new StringBuilder();
        int ai = a.length() - 1, bi = b.length() - 1;
        boolean carry = false;
        while (ai >= 0 && bi >= 0) {
            char cha = a.charAt(ai), chb = b.charAt(bi);
            if (carry) {
                if (cha == '0' && chb == '0') {
                    sb.append("1");
                    carry = false;
                } else if (cha == '1' && chb == '1')
                    sb.append("1");
                else
                    sb.append("0");
            } else {
                if (cha == '0' && chb == '0') {
                    sb.append("0");
                    carry = false;
                } else if (cha == '1' && chb == '1') {
                    sb.append("0");
                    carry = true;
                } else
                    sb.append("1");
            }
            ai--;
            bi--;
        }
        String s = ai == -1 ? b : a;
        int i = Math.abs(a.length() - b.length()) - 1;
        for (; i >= 0; i--) {
            char ch = s.charAt(i);
            if (carry) {
                if (ch == '0') {
                    sb.append("1");
                    carry = false;
                } else
                    sb.append("0");
            } else {
                if (ch == '0') {
                    sb.append("0");
                } else
                    sb.append("1");
            }
        }
        if (carry)
            sb.append("1");

        return sb.reverse().toString();
    }
}
// @lc code=end
