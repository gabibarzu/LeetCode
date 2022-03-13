using System;

namespace LeetCode.Solutions.TreesAndGraphs
{
    public class BinaryTreeMaximumPathSum
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

        private static int _maxValue = int.MinValue;

        public static int Solution(TreeNode node)
        {
            MaxGain(node);
            return _maxValue;
        }

        private static int MaxGain(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            var leftGain = Math.Max(0, MaxGain(node.Left));
            var rightGain = Math.Max(0, MaxGain(node.Right));

            _maxValue = Math.Max(_maxValue, node.Val + leftGain + rightGain);

            return node.Val + Math.Max(leftGain, rightGain);
        }
    }
}