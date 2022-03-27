using LeetCode.Solutions.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class ThreeSumTests
    {
        [TestMethod]
        [Ignore]
        public void Test_1()
        {
            var nums = new[] { -1, 0, 1, 2, -1, -4 };
            var solution = ThreeSum.ThreeSumSolution(nums);
        }

        [TestMethod]
        [Ignore]
        public void Test_2()
        {
            var nums = new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            var solution = ThreeSum.ThreeSumSolution(nums);
        }
    }
}