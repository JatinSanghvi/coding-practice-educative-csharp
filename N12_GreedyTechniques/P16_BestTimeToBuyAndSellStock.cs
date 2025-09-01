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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P16_BestTimeToBuyAndSellStock;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
