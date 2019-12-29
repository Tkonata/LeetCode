import javax.crypto.spec.ChaCha20ParameterSpec;

/*
 * @lc app=leetcode id=8 lang=java
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
class Solution {
    public int myAtoi(String str) {
        if (str.length() == 0)
            return 0;
        int index = 0;
        int answer = 0;
        int sign = 1;
        char num = str.charAt(index);
        while (!Character.isDigit(num)) {
            if (Character.isWhitespace(num)) {
                index++;
                if (index >= str.length())
                    return answer;
                num = str.charAt(index);
                continue;
            }
            if (Character.isLetter(num) || num == '.')
                return answer;
            if (num == '-') {
                index++;
                sign = -1;
                break;
            } else if (num == '+') {
                index++;
                break;
            }
            if (index >= str.length())
                return answer;
            num = str.charAt(index);
        }
        if (index >= str.length())
            return answer;
        if (!Character.isDigit(str.charAt(index)))
            return 0;
        while (str.charAt(index) == '0') {
            index++;
            if (index >= str.length())
                return answer;
        }

        if (Character.isDigit(str.charAt(index)))
            answer += str.charAt(index) - '0';
        else
            return answer;
        index++;
        for (int count = 0; count < 8; count++) {
            if (index >= str.length()) {
                return answer * sign;
            }
            num = str.charAt(index);
            if (!Character.isDigit(num)) {
                return answer * sign;
            }
            answer = 10 * answer + num - '0';
            index++;
        }
        if (index >= str.length())
            return answer * sign;
        num = str.charAt(index);
        if (!Character.isDigit(num)) {
            return answer * sign;
        }
        boolean overflow = answer > Integer.MAX_VALUE / 10;
        if (overflow) {
            if (sign == 1) {
                return Integer.MAX_VALUE;
            } else {
                return Integer.MIN_VALUE;
            }
        }
        answer = answer * 10 + num - '0';
        if (answer < 0) {
            if (sign == 1) {
                return Integer.MAX_VALUE;
            } else {
                return Integer.MIN_VALUE;
            }
        }
        index++;
        if (index >= str.length())
            return answer * sign;
        num = str.charAt(index);
        if (Character.isDigit(num)) {
            if (sign == 1) {
                return Integer.MAX_VALUE;
            } else {
                return Integer.MIN_VALUE;
            }
        }
        return answer * sign;
    }
}
// @lc code=end
