namespace LeetCode.Solutions.TreesAndGraphs
{
    /// <summary>
    /// 116. Populating Next Right Pointers in Each Node
    /// </summary>
    public class PopulatingNextRightPointersInEachNode
    {
        public class Node
        {
            public int Val;
            public Node Left;
            public Node Right;
            public Node Next;

            public Node(int val, Node left, Node right, Node next)
            {
                Val = val;
                Left = left;
                Right = right;
                Next = next;
            }
        }
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }

            var leftNode = root;
            while (leftNode.Left != null)
            {
                var head = leftNode;
                while (head != null)
                {
                    head.Left.Next = head.Right;
                    if (head.Next != null)
                    {
                        head.Right.Next = head.Next.Left;
                    }
                    head = head.Next;
                }
                leftNode = leftNode.Left;
            }
            return root;
        }
    }
}