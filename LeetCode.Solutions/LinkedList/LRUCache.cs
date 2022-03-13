using System.Collections.Generic;

namespace LeetCode.Solutions.LinkedList
{
    public class LruCache
    {
        public Node Head = new();
        public Node Tail = new();
        public Dictionary<int, Node> NodeMap;
        public int Capacity;

        public LruCache(int capacity)
        {
            NodeMap = new Dictionary<int, Node>(capacity);
            this.Capacity = capacity;
            Head.Next = this.Tail;
            Tail.Previous = this.Head;
        }

        public int Get(int key)
        {
            var result = -1;
            this.NodeMap.TryGetValue(key, out var node);
            if (node == null)
            {
                return result;
            }
            result = node.Val;
            Remove(node);
            Add(node);

            return result;
        }

        public void Put(int key, int value)
        {
            this.NodeMap.TryGetValue(key, out var node);
            if (node != null)
            {
                Remove(node);
                node.Val = value;
                Add(node);
            }
            else
            {
                if (NodeMap.Count == Capacity)
                {
                    NodeMap.Remove(this.Tail.Previous.Key);
                    Remove(this.Tail.Previous);
                }

                var newNode = new Node
                {
                    Key = key,
                    Val = value
                };

                NodeMap.Add(key, newNode);
                Add(newNode);
            }
        }

        public void Add(Node node)
        {
            var headNext = this.Head.Next;
            this.Head.Next = node;
            node.Previous = this.Head;
            node.Next = headNext;
            headNext.Previous = node;
        }

        public void Remove(Node node)
        {
            var next = node.Next;
            var previous = node.Previous;

            previous.Next = next;
            next.Previous = previous;
        }

        public class Node
        {
            public int Key;
            public int Val;
            public Node Previous;
            public Node Next;
        }
    }
}