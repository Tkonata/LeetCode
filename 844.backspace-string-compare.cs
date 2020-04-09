/*
 * @lc app=leetcode id=844 lang=csharp
 *
 * [844] Backspace String Compare
 */

// @lc code=start
public class Solution
{
    public bool BackspaceCompare(string S, string T) {
        var sStack = new Stack<char>();
        var tStack = new Stack<char>();
        foreach(var item in S) {
            if(item == '#') {
                if(sStack.Count != 0)
                    sStack.Pop();
            }
            else {
                sStack.Push(item);
            }
        }
        foreach(var item in T) {
            if(item == '#') {
                if(tStack.Count != 0)
                    tStack.Pop();
            }
            else {
                tStack.Push(item);
            }
        }
        if(sStack.Count != tStack.Count)
            return false;
        var count = sStack.Count;
        for(int i = 0; i < count; i++) {
            if(sStack.Peek() != tStack.Peek())
                return false;
            else {
                sStack.Pop();
                tStack.Pop();
            }
        }
        return true;
    }
}
// @lc code=end

