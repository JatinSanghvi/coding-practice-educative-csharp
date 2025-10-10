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

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P02_CoinChange;

public class Solution
{
    // Time complexity: O(ct), Space complexity: O(t).
    public static int CoinChange(int[] coins, int total)
    {
        int[] counts = Enumerable.Repeat(int.MaxValue, total + 1).ToArray();
        counts[0] = 0;

        foreach (int coin in coins)
        {
            for (int i = coin; i < total + 1; i++)
            {
                if (counts[i - coin] != int.MaxValue)
                {
                    counts[i] = Math.Min(counts[i], counts[i - coin] + 1);
                }
            }
        }

        return counts[total] == int.MaxValue ? -1 : counts[total];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 5, 15], 100, 8); // 90 + 10
        Run([2, 5, 15], 99, 9); // 90 + 5 + 4
    }

    private static void Run(int[] coins, int total, int expectedResult)
    {
        int result = Solution.CoinChange(coins, total);
        Utilities.PrintSolution((coins, total), result);
        Assert.AreEqual(expectedResult, result);
    }
}
