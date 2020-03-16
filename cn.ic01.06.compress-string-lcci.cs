/*
 * @lc lang=csharp
 *
 * [面试题 01.06] - 字符串压缩
 */


public class Solution
{
    // 需要考虑 "" 这一特殊情况
    public string CompressString(string S) {
        if(S == string.Empty) return S;
        int left = 0, right = 1;
        var compressed = new List<string>();
        for(; right < S.Length; right++) {
            if(S[right] != S[left]) {
                compressed.Add(S[left] + (right - left).ToString());
                left = right;
            }
        }
        compressed.Add(S[left] + (right - left).ToString());
        var res = string.Join(null, compressed);
        return res.Length >= S.Length ? S : res;
    }
}