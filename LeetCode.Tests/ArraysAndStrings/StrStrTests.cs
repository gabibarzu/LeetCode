using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class StrStrTests
    {
        [TestMethod]
        public void Test_1()
        {
            var haystack = "hello";
            var needle = "ll";
            var solution = StrStr.Solution(haystack, needle);
            solution.Should().Be(2);
        }

        [TestMethod]
        public void Test_2()
        {
            var haystack = "";
            var needle = "";
            var solution = StrStr.Solution(haystack, needle);
            solution.Should().Be(0);
        }

        [TestMethod]
        public void Test_3()
        {
            var haystack = "aa";
            var needle = "aaa";
            var solution = StrStr.Solution(haystack, needle);
            solution.Should().Be(-1);
        }

    }
}