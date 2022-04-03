using FluentAssertions;
using LeetCode.Solutions.DynamicProgramming;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.DynamicProgramming
{
    [TestClass]
    public class CoinChangeTests
    {
        [TestMethod]
        public void Test_1()
        {
            var coins = new[] { 1, 2, 5 };
            const int amount = 11;
            var result = CoinChange.CoinChangeSolution(coins, amount);

            result.Should().Be(3);
        }

        [TestMethod]
        public void Test_2()
        {
            var coins = new[] { 186, 419, 83, 408 };
            const int amount = 6249;
            var result = CoinChange.CoinChangeSolution(coins, amount);

            result.Should().Be(20);
        }
    }
}
