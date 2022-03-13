using LeetCode.Solutions.ArraysAndStrings;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.ArraysAndStrings
{
    [TestClass]
    public class IntegerToEnglishWordsTests
    {
        [TestMethod]
        [DataRow(123, "One Hundred Twenty Three")]
        [DataRow(12345, "Twelve Thousand Three Hundred Forty Five")]
        [DataRow(1234567, "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven")]
        public void Test(int num, string expected)
        {
            var result = IntegerToEnglishWords.NumberToWords(num);

            result.Should().Be(expected);
        }
    }
}