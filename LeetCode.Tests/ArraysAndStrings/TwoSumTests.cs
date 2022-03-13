using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class TwoSumTests
    {
        [TestMethod]
        public void Test_1()
        {
            var nums = new[] { 2, 7, 11, 15 };
            const int target = 26;
            var solution = TwoSum.Solution(nums, target);
            solution.Should().Contain(2).And.Contain(3);
        }        
        
        [TestMethod]
        public void Test_2()
        {
            var nums = new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            const int target = 11;
            var solution = TwoSum.Solution(nums, target);
            solution.Should().Contain(5).And.Contain(11);
        }
    }
}