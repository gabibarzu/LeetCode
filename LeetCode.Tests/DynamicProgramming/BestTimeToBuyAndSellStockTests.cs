using LeetCode.Solutions.DynamicProgramming;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Tests.DynamicProgramming
{
    [TestClass]
    public class BestTimeToBuyAndSellStockTests
    {
        [TestMethod]
        public void Test_1()
        {
            var prices = new[] { 7, 1, 5, 3, 6, 4 };

            var result = BestTimeToBuyAndSellStock.MaxProfitWithBrutForce(prices);

            result.Should().Be(5);
        }        
        
        [TestMethod]
        public void Test_2()
        {
            var prices = new[] { 7, 1, 5, 3, 6, 4 };

            var result = BestTimeToBuyAndSellStock.MaxProfitWithInStep(prices);

            result.Should().Be(5);
        }
    }
}