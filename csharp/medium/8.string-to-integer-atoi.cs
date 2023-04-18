/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 */

// @lc code=start
public class Solution
{
    enum State { Start, Signed, InNumber, End };
    Dictionary<(State, int), State> dic;

    public Solution() {
        dic = new Dictionary<(State, int), State>();
        dic.Add((State.Start, 0), State.Start);
        dic.Add((State.Start, 1), State.Signed);
        dic.Add((State.Start, 2), State.InNumber);
        dic.Add((State.Start, 3), State.End);
        dic.Add((State.Signed, 0), State.End);
        dic.Add((State.Signed, 1), State.End);
        dic.Add((State.Signed, 2), State.InNumber);
        dic.Add((State.Signed, 3), State.End);
        dic.Add((State.InNumber, 0), State.End);
        dic.Add((State.InNumber, 1), State.End);
        dic.Add((State.InNumber, 2), State.InNumber);
        dic.Add((State.InNumber, 3), State.End);
        dic.Add((State.End, 0), State.End);
        dic.Add((State.End, 1), State.End);
        dic.Add((State.End, 2), State.End);
        dic.Add((State.End, 3), State.End);
    }
    public int MyAtoi(string str) {
        long res = 0;
        int sign = 1;
        var state = State.Start;
        foreach(var ch in str) {
            state = dic[(state, GetAlpha(ch))];
            if(state == State.InNumber) {
                res = res * 10 + ch - '0';
                res = sign == 1 ? Math.Min(res, (long)int.MaxValue) : Math.Min(res, -(long)int.MinValue);
            }
            else if(state == State.Signed)
                sign = ch == '+' ? 1 : -1;
        }
        return (int)(sign * res);
    }

    private int GetAlpha(char ch) {
        if(char.IsWhiteSpace(ch)) return 0;
        else if(ch == '+' || ch == '-') return 1;
        else if(char.IsNumber(ch)) return 2;
        else return 3;
    }
}
// @lc code=end

