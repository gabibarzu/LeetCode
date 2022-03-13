using FluentAssertions;
using LeetCode.Solutions.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class ValidParenthesesTests
    {
        [TestMethod]
        public void Test_1()
        {
            var s = "{()]";
            var solution = ValidParentheses.Solution(s);
            solution.Should().BeFalse();
        }

        [TestMethod]
        public void Test_2()
        {
            var s = "()[]{}";
            var solution = ValidParentheses.Solution(s);
            solution.Should().BeTrue();
        }
    }
}