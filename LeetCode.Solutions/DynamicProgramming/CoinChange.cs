using System;

namespace LeetCode.Solutions.DynamicProgramming
{
    /// <summary>
    /// 322. Coin Change
    /// Url: https://leetcode.com/problems/coin-change/
    /// Time complexity: O (S * N) S - amount, N - coins
    /// Time complexity: O (N) N - coins
    /// </summary>
    public class CoinChange
    {
        public static int CoinChangeSolution(int[] coins, int amount)
        {
            var dp = new int[amount + 1];
            Array.Fill(dp, amount + 1);
            dp[0] = 0;
            for (var i = 1; i <= amount; i++)
            {
                foreach (var coin in coins)
                {
                    if (coin <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
        }
    }
}