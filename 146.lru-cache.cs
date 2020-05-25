/*
 * @lc app=leetcode id=146 lang=csharp
 *
 * [146] LRU Cache
 */

// @lc code=start
public class LRUCache
{
    private Dictionary<int, Node> map;
    private DoubleList cache;
    private int _capacity;
    public LRUCache(int capacity) {
        _capacity = capacity;
        map = new Dictionary<int, Node>();
        cache = new DoubleList();
    }

    public int Get(int key) {
        if(!map.ContainsKey(key))
            return -1;
        var val = map[key].value;
        Put(key, val);
        return val;
    }

    public void Put(int key, int value) {
        if(map.ContainsKey(key)) {
            var node = map[key];
            node.value = value;
            cache.Remove(node);
            cache.AddFirst(node);
        }
        else {
            if(_capacity == map.Count) {
                var last = cache.RemoveLast();
                map.Remove(last.key);
            }
            var node = new Node(key, value);
            map.Add(key, node);
            cache.AddFirst(node);
        }
    }
}
public class Node
{
    public int key, value;
    public Node next, prev;
    public Node(int key, int value) {
        this.key = key;
        this.value = value;
    }
}
public class DoubleList
{
    private Node head, tail;
    public DoubleList() {
        head = new Node(0, 0);
        tail = new Node(0, 0);
        head.next = tail;
        tail.prev = head;
        Count = 0;
    }
    public int Count { get; private set; }
    public void AddFirst(Node x) {
        x.next = head.next;
        head.next.prev = x;
        x.prev = head;
        head.next = x;
        Count++;
    }
    public void Remove(Node x) {
        if(x.prev != null && x.next != null) {
            x.prev.next = x.next;
            x.next.prev = x.prev;
            Count--;
        }

    }
    public Node RemoveLast() {
        if(Count != 0) {
            var node = tail.prev;
            node.prev.next = tail;
            tail.prev = node.prev;
            Count--;
            return node;
        }
        return null;
    }
}
/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
// @lc code=end

