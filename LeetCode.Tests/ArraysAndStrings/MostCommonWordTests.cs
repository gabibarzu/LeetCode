using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class MostCommonWordTests
    {
        [TestMethod]
        public void Test_1()
        {
            var paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            var banned = new[] { "hit" };
            var solution = MostCommonWord.MostCommonWordSolution(paragraph, banned);
            solution.Should().Be("ball");
        }

        [TestMethod]
        public void Test_2()
        {
            var paragraph = "Bob. hIt, baLl";
            var banned = new[] { "bob", "hit" };
            var solution = MostCommonWord.MostCommonWordSolution(paragraph, banned);
            solution.Should().Be("ball");
        }
    }
}