using System.Collections.Generic;

namespace LeetCode.Solutions.TreesAndGraphs
{
    public class BinaryTreeZigzagLevelOrderTraversal
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

        protected void Dfs(TreeNode node, int level, List<List<int>> results)
        {
            if (level >= results.Count)
            {
                var newLevel = new List<int>();
                newLevel.Add(node.Val);
                results.Add(newLevel);
            }
            else
            {
                if (level % 2 == 0)
                {
                    results[level].Add(node.Val);
                }
                else
                {
                    results[level].Add(node.Val);
                }
            }

            if (node.Left != null)
            {
                Dfs(node.Left, level + 1, results);
            }

            if (node.Right != null)
            {
                Dfs(node.Right, level + 1, results);
            }
        }

        public List<List<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<List<int>>();
            }

            var results = new List<List<int>>();
            Dfs(root, 0, results);
            return results;
        }
    }
}