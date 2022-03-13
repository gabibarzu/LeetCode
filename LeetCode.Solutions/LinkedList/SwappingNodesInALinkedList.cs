namespace LeetCode.Solutions.LinkedList
{
    /// <summary>
    /// 1721. Swapping Nodes in a Linked List
    /// URL: https://leetcode.com/problems/swapping-nodes-in-a-linked-list/
    /// Time: O(n)
    /// Space: O(1)
    /// </summary>
    public class SwappingNodesInALinkedList
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

        public ListNode SwapNodes(ListNode head, int k)
        {
            // find the length of linked list
            var listLength = GetListLength(head);

            // set the front node at kth node
            var frontNode = head;
            for (var i = 1; i < k; i++)
            {
                frontNode = frontNode.Next;
            }

            //set the end node at (listLength - k)th node
            var endNode = head;
            for (var i = 1; i <= listLength - k; i++)
            {
                endNode = endNode.Next;
            }

            // swap the values of front node and end node
            (frontNode.Val, endNode.Val) = (endNode.Val, frontNode.Val);
            return head;
        }

        private static int GetListLength(ListNode currentNode)
        {
            var listLength = 0;
            while (currentNode != null)
            {
                listLength++;
                currentNode = currentNode.Next;
            }

            return listLength;
        }
    }
}
