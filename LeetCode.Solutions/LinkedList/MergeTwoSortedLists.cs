namespace LeetCode.Solutions.LinkedList
{
    public static class MergeTwoSortedLists
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

        public static ListNode Solution(ListNode list1, ListNode list2)
        {
            var result = new ListNode();
            var current = result;

            while (list1 != null && list2 != null)
            {

                if (list1.Val <= list2.Val)
                {
                    current.Next = new ListNode(list1.Val);
                    list1 = list1.Next;
                }
                else
                {
                    current.Next = new ListNode(list2.Val);
                    list2 = list2.Next;
                }

                current = current.Next;
            }

            if (list1 == null)
            {
                while (list2 != null)
                {
                    current.Next = new ListNode(list2.Val);
                    list2 = list2.Next;
                    current = current.Next;
                }
            }

            if (list2 == null)
            {
                while (list1 != null)
                {
                    current.Next = new ListNode(list1.Val);
                    list1 = list1.Next;
                    current = current.Next;
                }
            }

            return result.Next;
        }
    }
}