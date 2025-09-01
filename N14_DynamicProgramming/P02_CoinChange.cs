// Coin Change
// ===========
//
// Given an integer `total` that represents the target amount of money and a list of integers `coins` that represents
// different coin denominations, find the minimum number of coins required to make up the total amount. If it's
// impossible to achieve the target amount using the given coins, return `-1`. If the target amount is 0, return `0`.
//
// > Note: You can assume that we have an infinite number of each kind of coin.
//
// Constraints:
//
// - 1 ≤ `coins.length` ≤ 12
// - 1 ≤ `coins[i]` ≤ 10^4
// - 0 ≤ `total` ≤ 900

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P02_CoinChange;

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
