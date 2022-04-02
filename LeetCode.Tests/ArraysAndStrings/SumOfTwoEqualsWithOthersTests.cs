using FluentAssertions;
using LeetCode.Solutions.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class SumOfTwoEqualsWithOthersTests
    {
        [TestMethod]
        public void Test_1()
        {
            var array = new[] { 2, 11, 5, 1, 4, 7 };
            var solution = SumOfTwoEqualsWithOthers.Solution(array);
            solution.Should().BeTrue();
        }

        [TestMethod]
        public void Test_2()
        {
            var array = new[] { 2, 4, 2, 1, 11, 15 };
            var solution = SumOfTwoEqualsWithOthers.Solution(array);
            solution.Should().BeFalse();
        }
    }
}