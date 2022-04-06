using FluentAssertions;
using LeetCode.Solutions.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.DynamicProgramming
{
    [TestClass]
    public class PartitionEqualSubsetSumTests
    {
        [TestMethod]
        public void Test_1()
        {
            var nums = new int[] { 1, 5, 11, 5 };

            var result = PartitionEqualSubsetSum.CanPartition(nums);

            result.Should().BeTrue();
        }

        [TestMethod]
        public void Test_2()
        {
            var nums = new int[] { 1, 1 };

            var result = PartitionEqualSubsetSum.CanPartition(nums);

            result.Should().BeTrue();
        }

        [TestMethod]
        public void Test_3()
        {
            var nums = new int[] { 2, 2, 1, 1 };

            var result = PartitionEqualSubsetSum.CanPartition(nums);

            result.Should().BeTrue();
        }

        [TestMethod]
        [Ignore]
        public void Test_4()
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var result = PartitionEqualSubsetSum.CanPartition(nums);

            result.Should().BeTrue();
        }
    }
}