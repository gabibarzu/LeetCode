using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class IsSubsequenceTests
    {
        [TestMethod]
        public void Test_1()
        {
            var s = "abc";
            var t = "ahbgdc";
            var solution = IsSubsequence.IsSubsequenceSolution(s, t);
            solution.Should().BeTrue();
        }

        [TestMethod]
        public void Test_2()
        {
            var s = "axc";
            var t = "ahbgdc";
            var solution = IsSubsequence.IsSubsequenceSolution(s, t);
            solution.Should().BeFalse();
        }
    }
}