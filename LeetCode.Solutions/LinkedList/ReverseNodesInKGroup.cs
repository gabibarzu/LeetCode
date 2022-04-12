namespace LeetCode.Solutions.LinkedList
{
    /// <summary>
    /// 25. Reverse Nodes in k-Group
    /// Url: https://leetcode.com/problems/reverse-nodes-in-k-group/
    /// Time complexity: O(n * K)
    /// Space complexity: O(1) 
    /// </summary>
    public class ReverseNodesInKGroup
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var root = new ListNode(0, head);
            var cur = head;
            var prev = root;

            while (cur != null)
            {
                var tail = cur;
                var listIndex = 0;

                while (cur != null && listIndex < k)
                {
                    cur = cur.next;
                    listIndex++;
                }

                if (listIndex != k)
                {
                    prev.next = tail;
                }
                else
                {
                    prev.next = ReverseListIterative(tail, k);
                    prev = tail;
                }
            }

            return root.next;
        }

        public ListNode ReverseListIterative(ListNode head, int k)
        {
            ListNode previous = null;
            while (head != null && k > 0)
            {
                var nextTemp = head.next;
                head.next = previous;
                previous = head;
                head = nextTemp;
                k--;
            }

            return previous;
        }
    }
}