/*
 * @lc lang=csharp
 *
 * [面试题59] - II. 队列的最大值
 */

// @lc code=start
public class MaxQueue
{
    private Queue<int> q;
    private LinkedList<int> Aid_q;

    public MaxQueue() {
        q = new Queue<int>();
        Aid_q = new LinkedList<int>();
    }

    public int Max_value() {
        if(q.Count == 0)
            return -1;
        return Aid_q.First.Value;
    }

    public void Push_back(int value) {
        q.Enqueue(value);
        while(Aid_q.Count != 0 && Aid_q.Last.Value < value) {
            Aid_q.RemoveLast();
        }
        Aid_q.AddLast(value);
    }

    public int Pop_front() {
        if(q.Count == 0)
            return -1;
        if(Aid_q.First.Value == q.Peek())
            Aid_q.RemoveFirst();
        return q.Dequeue();
    }
}
// @lc code=end