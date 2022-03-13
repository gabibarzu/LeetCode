namespace LeetCode.Solutions.LinkedList
{
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

        public static ListNode Solution(ListNode head)
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
    }
}