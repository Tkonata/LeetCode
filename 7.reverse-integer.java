import java.util.List;

/*
 * @lc app=leetcode id=7 lang=java
 *
 * [7] Reverse Integer
 */
class Solution {
    public int reverse(int x) {
        if (x == 0)
            return 0;
        int ab = 0;
        if (x < 0)
            ab = 1;
        long xx = (long) x;
        xx = Math.abs(xx);
        while (true) {
            long s = xx % 10;
            if (s != 0)
                break;
            xx /= 10;
        }
        List<String> as = new ArrayList<>();
        while (xx != 0) {
            long s = xx % 10;
            as.add(String.valueOf(s));
            xx /= 10;
        }
        long result = 0;
        for (String str : as) {
            int tmp = Integer.parseInt(str);
            result *= 10;
            result += tmp;
        }
        if (ab == 1)
            result = -result;
        if (result > Integer.MAX_VALUE || result < Integer.MIN_VALUE)
            return 0;
        return (int) result;
    }
}
