using FluentAssertions;
using LeetCode.Solutions.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.DynamicProgramming
{
    [TestClass]
    public class LongestPalindromicSubstringTests
    {
        [TestMethod]
        public void Test_1()
        {
            var s = "cbbd";

            var result = LongestPalindromicSubstring.LongestPalindrome(s);

            result.Should().Be("bb");
        }
    }
}