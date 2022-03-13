namespace LeetCode.Solutions.LinkedList
{
    /// <summary>
    /// 206. Reverse Linked List
    /// URL: https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    public static class ReverseLinkedList
    {
        public class ListNode
        {
            public int Val;
            public ListNode Next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.Val = val;
                this.Next = next;
            }
        }

        /// <summary>
        /// Iterative way
        /// Time: O(n)
        /// Space: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseListIterative(ListNode head)
        {
            ListNode previous = null;
            while (head != null)
            {
                var nextTemp = head.Next;
                head.Next = previous;
                previous = head;
                head = nextTemp;
            }

            return previous;
        }

        /// <summary>
        /// Iterative way
        /// Time: O(n)
        /// Space: O(1)
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseListRecursive(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            var newHead = head;
            if (head.Next != null)
            {
                newHead = ReverseListRecursive(head.Next);
                head.Next.Next = head;
            }

            head.Next = null;

            return newHead;
        }
    }
}