using FluentAssertions;
using LeetCode.Solutions.TreesAndGraphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.TreesAndGraphs
{
    [TestClass]
    public class SymmetricTreeTests
    {
        [TestMethod]
        public void Test_1()
        {
            var leftNode = new SymmetricTree.TreeNode(1);
            var rightNode = new SymmetricTree.TreeNode(3);
            var root = new SymmetricTree.TreeNode(2, leftNode, rightNode);

            var solution = SymmetricTree.IsSymmetric(root);

            solution.Should().BeFalse();
        }

        [TestMethod]
        public void Test_2()
        {

            var leftLeftNode = new SymmetricTree.TreeNode(3);
            var leftRightNode = new SymmetricTree.TreeNode(4);
            var leftNode = new SymmetricTree.TreeNode(2, leftLeftNode, leftRightNode);

            var rightLeftNode = new SymmetricTree.TreeNode(4);
            var rightRightNode = new SymmetricTree.TreeNode(3);
            var rightNode = new SymmetricTree.TreeNode(2, rightLeftNode, rightRightNode);
            
            var root = new SymmetricTree.TreeNode(1, leftNode, rightNode);

            var solution = SymmetricTree.IsSymmetric(root);

            solution.Should().BeTrue();
        }

    }
}