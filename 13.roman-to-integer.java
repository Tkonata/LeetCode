import java.util.Map;

/*
 * @lc app=leetcode id=13 lang=java
 *
 * [13] Roman to Integer
 */
class Solution {
    public int romanToInt(String s) {
        Map<Character, Integer> r2i = new HashMap<>();
        r2i.put('I', 1);
        r2i.put('V', 5);
        r2i.put('X', 10);
        r2i.put('L', 50);
        r2i.put('C', 100);
        r2i.put('D', 500);
        r2i.put('M', 1000);
        int target = 0;
        for (int i = 0; i < s.length(); i++) {
            if (i + 1 >= s.length() || r2i.get(s.charAt(i)) >= r2i.get(s.charAt(i + 1)))
                target += r2i.get(s.charAt(i));
            else
                target -= r2i.get(s.charAt(i));
        }
        return target;
    }
}
