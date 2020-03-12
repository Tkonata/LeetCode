/*
 * @lc app=leetcode id=1071 lang=csharp
 *
 * [1071] Greatest Common Divisor of Strings
 */

// @lc code=start
public class Solution
{
    public string GcdOfStrings(string str1, string str2) {
        if(str1 + str2 != str2 + str1)
            return string.Empty;

        // return str1.Substring(0, str1.Length > str2.Length ? gcd1(str1.Length, str2.Length) : gcd1(str2.Length, str1.Length));
        // return str1.Substring(0, gcd2(str1.Length, str2.Length));
        return str1.Substring(0, gcd3(str1.Length, str2.Length));
    }

    /// <summary>
    /// 辗转相除法
    /// </summary>
    private int gcd1(int l1, int l2) => l2 == 0 ? l1 : gcd1(l2, l1 % l2);

    /// <summary>
    /// 更相减损术
    /// </summary>
    private int gcd2(int l1, int l2) {
        if(l1 == l2)
            return l1;
        if(l1 > l2)
            return gcd2(l1 - l2, l2);
        else
            return gcd2(l2 - l1, l1);
    }

    /// <summary>
    /// 更相减损术与移位结合
    /// </summary>
    private int gcd3(int l1, int l2) {
        if(l1 == l2)
            return l1;
        if(l1 < l2)
            return gcd3(l2, l1);
        else {
            var IsEven1 = l1 % 2 == 0;
            var IsEven2 = l2 % 2 == 0;

            if(IsEven1 && IsEven2)
                return gcd3(l1 >> 1, l2 >> 1) << 1;
            else if(IsEven1 && !IsEven2)
                return gcd3(l1 >> 1, l2);
            else if(!IsEven1 && IsEven2)
                return gcd3(l1, l2 >> 1);
            else
                return gcd3(l2, l1 - l2);
        }
    }
}
// @lc code=end

