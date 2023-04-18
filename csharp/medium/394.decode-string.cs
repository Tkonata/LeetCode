/*
 * @lc app=leetcode id=394 lang=csharp
 *
 * [394] Decode String
 */

// @lc code=start
public class Solution
{
    public string DecodeString(string s) {
        var stack = new Stack<(int multi, StringBuilder sb)>();
        var multi = 0;
        var sb = new StringBuilder();
        foreach(var item in s) {
            if(item == '[') {
                stack.Push((multi, sb));
                sb = new StringBuilder();
                multi = 0;
            }
            else if(item == ']') {
                var top = stack.Pop();
                multi = top.multi;
                for(int i = 0; i < multi; i++)
                    top.sb.Append(sb);
                sb = top.sb;
                multi = 0;
            }
            else if(item >= '0' && item <= '9') {
                var tmp = int.Parse(item.ToString());
                multi = multi * 10 + tmp;
            }
            else
                sb.Append(item);
        }
        return sb.ToString();
    }
}
// @lc code=end

