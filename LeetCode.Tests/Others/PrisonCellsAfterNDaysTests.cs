using LeetCode.Solutions.Others;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Others
{
    [TestClass]
    public class PrisonCellsAfterNDaysTests
    {
        [TestMethod]
        public void Test_1()
        {
            var nums = new[] { 0, 1, 0, 1, 1, 0, 0, 1 };
            var n = 7;

            var solution = PrisonCellsAfterNDays.PrisonAfterNDays(nums, n);

        }
    }
}