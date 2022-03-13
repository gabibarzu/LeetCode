using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class CompareVersionNumbersTests
    {
        [TestMethod]
        public void Test_1()
        {
            const string version1 = "1.01";
            const string version2 = "1.001";
            var solution = CompareVersionNumbers.Solution(version1, version2);
            solution.Should().Be(0);
        }

        [TestMethod]
        public void Test_2()
        {
            const string version1 = "1.01.0";
            const string version2 = "1.001.0";
            var solution = CompareVersionNumbers.Solution(version1, version2);
            solution.Should().Be(0);
        }

        [TestMethod]
        public void Test_3()
        {
            const string version1 = "1.01.0";
            const string version2 = "1.001.1";
            var solution = CompareVersionNumbers.Solution(version1, version2);
            solution.Should().Be(-1);
        }
    }
}