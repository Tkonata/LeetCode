/*
 * @lc app=leetcode id=1046 lang=csharp
 *
 * [1046] Last Stone Weight
 */

// @lc code=start
public class Solution
{
    private SortedList<int, int> list;
    private int count = 0;
    public int LastStoneWeight(int[] stones) {
        list = new SortedList<int, int>(stones.Length);
        foreach(var item in stones) {
            Enqueue(item);
        }
        while(count > 1) {
            var y = Dequeue();
            var x = Dequeue();
            if(x != y)
                Enqueue(y - x);
        }
        return list.Count == 0 ? 0 : Peek();
    }

    private void Enqueue(int num) {
        if(!list.ContainsKey(num))
            list.Add(num, 0);
        list[num]++;
        count++;
    }

    private int Dequeue() {
        var maxKey = list.Keys.Last();
        var c = --list[maxKey];
        count--;
        if(c == 0)
            list.Remove(maxKey);
        return maxKey;
    }

    private int Peek() {
        return list.Keys.Last();
    }
}
// @lc code=end

