using System.Collections.Generic;

namespace LeetCode.Solutions.TreesAndGraphs
{
    public class BinaryTreeLevelOrderTraversal
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

        private readonly IList<IList<int>> _levels = new List<IList<int>>();

        public void AddNodesToLevel(TreeNode node, int level)
        {
            // start the current level
            if (_levels.Count == level)
            {
                _levels.Add(new List<int>());
            }

            // fil the current level
            _levels[level].Add(node.Val);

            // process child nodes for the next level
            if (node.Left != null)
            {
                AddNodesToLevel(node.Left, level + 1);
            }
            if (node.Right != null)
            {
                AddNodesToLevel(node.Right, level + 1);
            }
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return _levels;
            }
            AddNodesToLevel(root, 0);
            return _levels;
        }
    }
}