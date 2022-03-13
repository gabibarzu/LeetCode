using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class StringToIntegerAtoiTests
    {
        [TestMethod]
        public void Test_1()
        {
            var s = "123";
            var solution = StringToIntegerAtoi.Solution(s);
            solution.Should().Be(123);
        }

        [TestMethod]
        public void Test_2()
        {
            var s = "        123";
            var solution = StringToIntegerAtoi.Solution(s);
            solution.Should().Be(123);
        }

        [TestMethod]
        public void Test_3()
        {
            var s = "        123 ";
            var solution = StringToIntegerAtoi.Solution(s);
            solution.Should().Be(123);
        }

        [TestMethod]
        public void Test_4()
        {
            var s = "        123a";
            var solution = StringToIntegerAtoi.Solution(s);
            solution.Should().Be(123);
        }

        [TestMethod]
        public void Test_5()
        {
            var s = "-123";
            var solution = StringToIntegerAtoi.Solution(s);
            solution.Should().Be(-123);
        }

        [TestMethod]
        public void Test_6()
        {
            var s = "-91283472332";
            var solution = StringToIntegerAtoi.Solution(s);
            solution.Should().Be(-2147483648);
        }
    }
}