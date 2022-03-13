using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        public void Test_1()
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            var target = 9;

            var result = BinarySearchTree.Search(nums, target);

            result.Should().Be(4);
        }

        [TestMethod]
        public void Test_2()
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };
            var target = 2;

            var result = BinarySearchTree.Search(nums, target);

            result.Should().Be(-1);
        }
    }
}