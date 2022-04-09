using System.Collections.Generic;

namespace LeetCode.Solutions.LinkedList
{
    /// <summary>
    /// 138. Copy List with Random Pointer
    /// Url: https://leetcode.com/problems/copy-list-with-random-pointer/
    /// Time complexity: O(n)
    /// Space complexity: O(n)
    /// </summary>
    public class CopyListWithRandomPointer
    {
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }

        public static Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }

            var copies = new Dictionary<Node, Node>();

            var current = head;
            while (current != null)
            {
                copies.Add(current, new Node(current.val));
                current = current.next;
            }

            current = head;
            while (current != null)
            {
                var copyNode = copies.GetValueOrDefault(current);
                if (copyNode != null)
                {
                    copyNode.next = current.next != null ? copies.GetValueOrDefault(current.next) : null;
                    copyNode.random = current.random != null ? copies.GetValueOrDefault(current.random) : null;
                }

                current = current.next;
            }

            return copies[head];
        }
    }
}