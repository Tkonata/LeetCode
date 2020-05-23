/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution
{
    public bool IsValid(string s) {
        var map = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        var stack = new Stack<char>();
        foreach(var item in s) {
            if(item == '(' || item == '[' || item == '{')
                stack.Push(item);
            if(map.ContainsKey(item)) {
                var ch = map[item];
                if(stack.Count != 0 && stack.Peek() == ch)
                    stack.Pop();
                else
                    return false;
            }
        }
        if(stack.Count != 0)
            return false;
        return true;
    }
}
// @lc code=end

