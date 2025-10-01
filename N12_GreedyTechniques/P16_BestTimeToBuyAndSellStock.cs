// Best Time to Buy and Sell Stock
// ===============================
//
// Given an array, `prices`, where `prices[i]` represent the price of a stock on the i-th day, maximize profit by
// selecting a single day to buy the stock and a different day in the future to sell it.
//
// Return the maximum profit that can be achieved from this transaction. If no profit can be made, return `0`.
//
// Constraints:
//
// - We can't sell before buying a stock, that is, the array index at which stock is bought will always be less than the
//   index at which the stock is sold.
// - 1 ≤ `prices.length` ≤ 10^3
// - 0 ≤ `prices[i]` ≤ 10^5

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P16_BestTimeToBuyAndSellStock;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int MaxProfit(int[] prices)
    {
        int minValue = prices[0];
        int maxProfit = 0;

        for (int i = 1; i != prices.Length; i++)
        {
            minValue = Math.Min(minValue, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minValue);
        }

        return maxProfit;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([3, 2, 4, 5, 1], 3);
    }

    private static void Run(int[] prices, int expectedResult)
    {
        int result = Solution.MaxProfit(prices);
        Utilities.PrintSolution(prices, result);
        Assert.AreEqual(expectedResult, result);
    }
}
