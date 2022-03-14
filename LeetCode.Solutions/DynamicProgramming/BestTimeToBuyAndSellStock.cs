using System;

namespace LeetCode.Solutions.DynamicProgramming
{
    /// <summary>
    /// 121. Best Time to Buy and Sell Stock
    /// URL: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    public class BestTimeToBuyAndSellStock
    {
        /// <summary>
        /// Brute Force
        /// Time: O (n^2)
        /// Space: O (1)
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfitWithBrutForce(int[] prices)
        {
            var maxProfit = 0;

            for (var i = 0; i < prices.Length - 1; i++)
            {
                for (var j = i + 1; j < prices.Length; j++)
                {
                    var profit = prices[j] - prices[i];
                    maxProfit = Math.Max(maxProfit, profit);
                }
            }

            return maxProfit;
        }

        public static int MaxProfitWithInStep(int[] prices)
        {
            var minPrice = int.MaxValue;
            var maxProfit = 0;
            foreach (var price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }
                else
                {
                    if (price - minPrice > maxProfit)
                    {
                        maxProfit = price - minPrice;
                    }
                }
            }
            return maxProfit;
        }
    }
}