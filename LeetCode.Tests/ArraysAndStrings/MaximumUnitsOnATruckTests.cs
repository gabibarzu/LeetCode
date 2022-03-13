using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class MaximumUnitsOnATruckTests
    {
        [TestMethod]
        public void Test_1()
        {
            var boxTypes = new[] { new[] { 2, 2 }, new[] { 1, 3 }, new[] { 3, 1 } };
            const int truckSize = 4;

            var result = MaximumUnitsOnATruck.MaximumUnits(boxTypes, truckSize);

            result.Should().Be(8);
        }

        [TestMethod]
        public void Test_2()
        {
            var boxTypes = new[] { new[] { 3, 10 }, new[] { 6, 5 }, new[] { 4, 7 }, new[] { 2, 9 } };
            const int truckSize = 8;

            var result = MaximumUnitsOnATruck.MaximumUnits(boxTypes, truckSize);

            result.Should().Be(69);
        }
    }
}