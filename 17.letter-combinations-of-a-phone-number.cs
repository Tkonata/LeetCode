/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 */

// @lc code=start
public class Solution
{
    private IList<string> ans;
    private StringBuilder sb;
    private string sample;
    private int index;
    private readonly Dictionary<char, string> map = new Dictionary<char, string> { { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" }, { '8', "tuv" }, { '9', "wxyz" } };
    public IList<string> LetterCombinations(string digits) {
        if(digits == string.Empty)
            return new List<string>(0);
        sample = digits;
        index = 0;
        ans = new List<string>();
        sb = new StringBuilder();
        Backtrack();
        return ans;
    }

    private void Backtrack() {
        if(index == sample.Length) {
            ans.Add(sb.ToString());
            return;
        }
        var nowCh = sample[index];
        foreach(var item in map[nowCh]) {
            sb.Append(item);
            index++;
            Backtrack();
            index--;
            sb.Remove(sb.Length - 1, 1);
        }
        return;
    }
}
// @lc code=end

