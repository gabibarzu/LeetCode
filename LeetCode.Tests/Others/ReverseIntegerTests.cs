using LeetCode.Solutions.Others;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.Others
{
    [TestClass]
    public class ReverseIntegerTests
    {
        [TestMethod]
        [DataRow(123, 321)]
        [DataRow(-123, -321)]
        [DataRow(0, 0)]
        [DataRow(1534236469, 0)]
        [DataRow(2147483647, 0)]
        [DataRow(1463847412, 0)]
        public void Test(int value, int expected)
        {
            var result = ReverseInteger.Reverse(value);

            result.Should().Be(expected);
        }
    }
}