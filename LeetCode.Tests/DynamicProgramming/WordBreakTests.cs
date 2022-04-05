using System.Collections.Generic;

using LeetCode.Solutions.DynamicProgramming;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using FluentAssertions;

namespace LeetCode.Tests.DynamicProgramming
{
    [TestClass]
    public class WordBreakTests
    {
        [TestMethod]
        public void Test_1()
        {
            var s = "leetcode";
            var wordDict = new List<string> { "leet", "code" };

            var result = WordBreak.WordBreakRecursive(s, wordDict);

            result.Should().BeTrue();
        }
    }
}