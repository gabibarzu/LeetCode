namespace LeetCode.Solutions.LinkedList
{
    public class AddTwoNumbers
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

        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            var result = new ListNode();

            var current = result;
            var carry = 0;

            while (l1 != null || l2 != null)
            {
                var firstValue = l1?.Val ?? 0;
                var secondValue = l2?.Val ?? 0;

                var sum = carry + firstValue + secondValue;
                carry = sum / 10;
                current.Next = new ListNode(sum % 10);
                current = current.Next;

                l1 = l1?.Next;
                l2 = l2?.Next;
            }

            if (carry > 0)
            {
                current.Next = new ListNode(carry);
            }

            return result.Next;
        }
    }
}