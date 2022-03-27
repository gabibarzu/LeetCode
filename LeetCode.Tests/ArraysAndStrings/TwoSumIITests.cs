using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class TwoSumIITests
    {
        [TestMethod]
        public void Test_1()
        {
            var nums = new[] { 2, 7, 11, 15 };
            const int target = 26;
            var solution = TwoSumII.TwoSum(nums, target);
            solution.Should().Contain(3).And.Contain(4);
        }

        [TestMethod]
        public void Test_2()
        {
            var nums = new[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4, 7 };
            const int target = 11;
            var solution = TwoSumII.TwoSum(nums, target);
            solution.Should().Contain(16).And.Contain(17);
        }
    }
}