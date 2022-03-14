using LeetCode.Solutions.SortingAndSearching;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.SortingAndSearching
{
    [TestClass]
    public class KthLargestElementInAnArrayTests
    {
        [TestMethod]
        public void Test_1()
        {
            var nums = new int[] { 3, 2, 1, 5, 6, 4 };
            var k = 2;

            var result = KthLargestElementInAnArray.FindKthLargestWithSortArray(nums, k);

            result.Should().Be(5);
        }
    }
}