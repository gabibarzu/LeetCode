using FluentAssertions;
using LeetCode.Solutions.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class ProductOfArrayExceptSelfTests
    {

        [TestMethod]
        public void Test_1()
        {
            var nums = new[] { 1, 2, 3, 4 };
            var solution = ProductOfArrayExceptSelf.ProductExceptSelf(nums);
            solution.Should().Contain(24).And.Contain(12).And.Contain(8).And.Contain(6);
        }
    }
}