using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod]
        [DataRow("abcabcbb", 3)]
        public void Test(string value, int expectedResult)
        {
            var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(value);

            result.Should().Be(expectedResult);
        }        
        
        [TestMethod]
        [DataRow("abcabcbb", 3)]
        public void TestForOptimizedMethod(string value, int expectedResult)
        {
            var result = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstringOptimized(value);

            result.Should().Be(expectedResult);
        }
    }
}