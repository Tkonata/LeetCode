/*
 * @lc app=leetcode id=1160 lang=csharp
 *
 * [1160] Find Words That Can Be Formed by Characters
 */

// @lc code=start
public class Solution
{
    public int CountCharacters(string[] words, string chars) {
        var alphabet = new Dictionary<char, int>();
        var letter = new Dictionary<char, int>();
        int res = 0;
        foreach(var ch in chars) {
            if(alphabet.ContainsKey(ch))
                alphabet[ch]++;
            else
                alphabet.Add(ch, 1);
        }
        foreach(var word in words) {
            bool isValid = true;
            foreach(var ch in word) {
                if(letter.ContainsKey(ch))
                    letter[ch]++;
                else
                    letter.Add(ch, 1);
            }
            foreach(var ele in letter) {
                if(!alphabet.ContainsKey(ele.Key) || alphabet[ele.Key] < ele.Value) {
                    isValid = false;
                    break;
                }
            }
            if(isValid) {
                res += word.Length;
            }
            letter.Clear();
        }
        return res;
    }
}
// @lc code=end

