// 0/1 Knapsack
// ============
//
// You are given `n` items whose weights and values are known, as well as a knapsack to carry these items. The knapsack
// cannot carry more than a certain maximum weight, known as its capacity.
//
// You need to maximize the total value of the items in your knapsack, while ensuring that the sum of the weights of the
// selected items does not exceed the capacity of the knapsack.
//
// If there is no combination of weights whose sum is within the capacity constraint, return 0.
//
// Notes:
// 1. An item may not be broken up to fit into the knapsack, i.e., an item either goes into the knapsack in its entirety
// or not at all.
// 2. We may not add an item more than once to the knapsack.
//
// Constraints:
//
// - 1 ≤ capacity ≤ 10^4
// - 1 ≤ values.length ≤ 10^3
// - weights.length == values.length
// - 1 ≤ values[i] ≤ 10^4
// - 1 ≤ values[i] ≤ capacity

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N14_DynamicProgramming.P01_0_1Knapsack;

public class Solution
{
    // Time complexity: O(n*c), Space complexity: O(c).
    public static int FindMaxKnapsackProfit(int capacity, int[] weights, int[] values)
    {
        var sumValues = new int[capacity + 1];

        for (int i = 0; i != weights.Length; i++)
        {
            for (int j = capacity; j != weights[i] - 1; j--)
            {
                sumValues[j] = Math.Max(sumValues[j], sumValues[j - weights[i]] + values[i]);
            }
        }

        return sumValues[capacity];
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(6, [1, 1, 2, 2, 3, 3], [11, 12, 13, 14, 15, 16], 50);
    }

    private static void Run(int capacity, int[] weights, int[] values, int expectedResult)
    {
        int result = Solution.FindMaxKnapsackProfit(capacity, weights, values);
        Utilities.PrintSolution((capacity, weights, values), result);
        Assert.AreEqual(expectedResult, result);
    }
}
