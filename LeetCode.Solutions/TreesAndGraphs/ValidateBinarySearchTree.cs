namespace LeetCode.Solutions.TreesAndGraphs
{
    public static class ValidateBinarySearchTree
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

        public static bool Solution(TreeNode root)
        {
            return Validate(root, long.MinValue, long.MaxValue);
        }

        private static bool Validate(TreeNode root, long low, long high)
        {
            if (root == null)
            {
                return true;
            }
            if (root.Val <= low || root.Val >= high)
            {
                return false;
            }
            return Validate(root.Left, low, root.Val) && Validate(root.Right, root.Val, high);
        }
    }
}