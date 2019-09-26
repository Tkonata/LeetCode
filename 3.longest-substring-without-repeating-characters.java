import java.util.HashMap;
import java.util.Map;

/*
 * @lc app=leetcode id=3 lang=java
 *
 * [3] Longest Substring Without Repeating Characters
 */
class Solution {
    public int lengthOfLongestSubstring(String s) {
        int le = s.length();
        int res = 0;
        Map<Character, Integer> map = new HashMap<>();
        for (int j = 0, i = 0; j < le; j++) {
            if (map.containsKey(s.charAt(j))) {
                i = Math.max(map.get(s.charAt(j)), i);
            }
            map.put(s.charAt(j), j + 1);
            res = Math.max(j - i + 1, res);
        }
        return res;
    }
}
