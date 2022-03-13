using LeetCode.Solutions.TreesAndGraphs;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.TreesAndGraphs
{
    [TestClass]
    public class BinaryTreeMaximumPathSumTests
    {
        [TestMethod]
        public void Test_1()
        {
            var leftNode = new BinaryTreeMaximumPathSum.TreeNode(2);
            var rightNode = new BinaryTreeMaximumPathSum.TreeNode(3);
            var root = new BinaryTreeMaximumPathSum.TreeNode(1, leftNode, rightNode);

            var solution = BinaryTreeMaximumPathSum.Solution(root);

            solution.Should().Be(6);
        }        
        
        
        [TestMethod]
        public void Test_2()
        {
            var leftNode = new BinaryTreeMaximumPathSum.TreeNode(2);

            var rightLeftNode = new BinaryTreeMaximumPathSum.TreeNode(4);
            var rightRightNode = new BinaryTreeMaximumPathSum.TreeNode(5);
            var rightNode = new BinaryTreeMaximumPathSum.TreeNode(3, rightLeftNode, rightRightNode);
            
            var root = new BinaryTreeMaximumPathSum.TreeNode(1, leftNode, rightNode);

            var solution = BinaryTreeMaximumPathSum.Solution(root);

            solution.Should().Be(12);
        }
    }
}