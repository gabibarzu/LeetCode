using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class MissingNumberTests
    {
        [TestMethod]
        public void Test_1()
        {
            var nums = new[] { 3, 0, 1 };
            var solution = MissingNumber.Solution(nums);
            solution.Should().Be(2);
        }

        [TestMethod]
        public void Test_2()
        {
            var nums = new[] { 0, 1 };
            var solution = MissingNumber.Solution(nums);
            solution.Should().Be(2);
        }

        [TestMethod]
        public void Test_3()
        {
            var nums = new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            var solution = MissingNumber.Solution(nums);
            solution.Should().Be(8);
        }
    }
}