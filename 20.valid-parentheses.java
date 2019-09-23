import java.util.Deque;
import java.util.HashMap;
import java.util.LinkedList;
import java.util.Map;

/*
 * @lc app=leetcode id=20 lang=java
 *
 * [20] Valid Parentheses
 */
class Solution {
    public boolean isValid(String s) {
        if (s.length() == 0)
            return true;
        if (s.length() % 2 != 0)
            return false;
        Deque<Character> st = new LinkedList<>();
        Map<Character, Character> map = new HashMap<>();
        map.put('}', '{');
        map.put(']', '[');
        map.put(')', '(');
        for (int i = 0; i < s.length(); i++) {
            Character ch = new Character(s.charAt(i));
            Character pre = st.peek();
            Character tmp = map.get(ch);
            if (pre != null && tmp != null && tmp.equals(pre))
                st.pop();
            else
                st.push(ch);
        }
        if (st.isEmpty())
            return true;
        else
            return false;
    }
}
