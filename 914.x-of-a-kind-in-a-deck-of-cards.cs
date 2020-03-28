/*
 * @lc app=leetcode id=914 lang=csharp
 *
 * [914] X of a Kind in a Deck of Cards
 */

// @lc code=start
public class Solution
{
    public bool HasGroupsSizeX(int[] deck) {
        var dic = new Dictionary<int, int>();
        foreach(var item in deck) {
            if(dic.ContainsKey(item))
                dic[item]++;
            else
                dic.Add(item, 1);
        }
        if(dic.ContainsValue(1)) return false;
        var arr = dic.Values.ToArray();
        var gcd = MultiGcd(arr);
        if(gcd == 1) return false;
        else return true;
    }
    private int MultiGcd(int[] arr) {
        Array.Sort(arr, (x, y) => -x.CompareTo(y));
        while(arr[0] != arr[arr.Length - 1]) {
            Array.Sort(arr, (x, y) => -x.CompareTo(y));
            for(int i = 0; i < arr.Length - 1; i++) {
                var c = arr[i] % arr[i + 1];
                arr[i] = c == 0 ? arr[i + 1] : c;
            }
        }
        return arr[0];
    }
}
// @lc code=end

