namespace LeetCode.Solutions.TreesAndGraphs
{
    public class SymmetricTree
    {
        public class TreeNode
        {
            public int Val;
            public TreeNode Left;
            public TreeNode Right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.Val = val;
                this.Left = left;
                this.Right = right;
            }
        }

        public static bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        private static bool IsMirror(TreeNode node1, TreeNode node2)
        {

            if (node1 == null && node2 == null)
            {
                return true;
            }

            if (node1 == null || node2 == null)
            {
                return false;
            }

            return node1.Val == node2.Val
                && IsMirror(node1.Right, node2.Left)
                && IsMirror(node1.Left, node2.Right);
        }
    }
}