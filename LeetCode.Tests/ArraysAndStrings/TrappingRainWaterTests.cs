using FluentAssertions;
using LeetCode.Solutions.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]

    public class TrappingRainWaterTests
    {

        [TestMethod]
        public void Test_1()
        {
            var height = new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            var solution = TrappingRainWater.Trap(height);
            solution.Should().Be(6);
        }
    }
}