/*
 * @lc app=leetcode id=365 lang=csharp
 *
 * [365] Water and Jug Problem
 */

// @lc code=start
public class Solution {
    private int curX, curY, maxX, maxY;
    public bool CanMeasureWater(int x, int y, int z) {
        if(z == 0) return true;
        if(x + y < z) return false;
        maxX = x; maxY = y;
        var initState = (0, 0);
        var queue = new Queue<(int, int)>();
        var visited = new HashSet<(int, int)>();
        visited.Add(initState);
        queue.Enqueue(initState);
        while(queue.Count != 0) {
            var head = queue.Dequeue();
            curX = head.Item1;
            curY = head.Item2;
            if(curX == z || curY == z || curX + curY == z) {
                return true;
            }
            var nextState = GetNextState();
            foreach(var item in nextState) {
                if(!visited.Contains(item)) {
                    queue.Enqueue(item);
                    visited.Add(item);
                }
            }
        }
        return false;
    }
    private List<(int, int)> GetNextState() {
        var nextState = new List<(int, int)>(6);
        if(curX < maxX) nextState.Add((maxX, curY));
        if(curY < maxY) nextState.Add((curX, maxY));
        if(curX > 0) nextState.Add((0, curY));
        if(curY > 0) nextState.Add((curX, 0));
        if(curX - (maxY - curY) > 0)
            nextState.Add((curX - (maxY - curY), maxY));
        else
            nextState.Add((0, curX + curY));
        if(curY - (maxX - curX) > 0)
            nextState.Add((maxX, curY - (maxX - curX)));
        else
            nextState.Add((curX + curY, 0));
        return nextState;
    }
}
// @lc code=end

