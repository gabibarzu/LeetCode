using FluentAssertions;
using LeetCode.Solutions.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class FirstUniqueCharacterInStringTests
    {
        [TestMethod]
        public void Test_1()
        {
            var s = "leetcode";
            var solution = FirstUniqueCharacterInString.Solution(s);
            solution.Should().Be(0);
        }        
        
        [TestMethod]
        public void Test_2()
        {
            var s = "aabb";
            var solution = FirstUniqueCharacterInString.Solution(s);
            solution.Should().Be(-1);
        }
    }
}