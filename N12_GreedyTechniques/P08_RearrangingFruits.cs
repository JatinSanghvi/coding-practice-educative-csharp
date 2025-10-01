// Rearranging Fruits
// ==================
//
// Given two 0-indexed integer arrays, `basket1` and `basket2`, representing the cost of each fruit in the basket. Each
// basket contains n fruits. Make the two baskets identical, i.e., both arrays should have the same weights.
//
// To achieve this, perform the following operation as many times as necessary:
//
// 1. Select two indexes, i and j, and swap the fruit at index i in `basket1` with the fruit at index j in `basket2`.
// 2. The cost of this swap is `min(basket1[i], basket2[j])`.
//
// The two baskets are considered identical if, after sorting the fruits by cost, both baskets contain exactly the same
// costs.
//
// Return the minimum cost required to make the baskets identical, or -1 if it is impossible.
//
// Constraints:
//
// - `basket1.length` == `basket2.length`
// - 1 ≤ `basket1.length` ≤ 10^3
// - 1 ≤ `basket1[i]`, `basket2[i]` ≤ 10^4

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P08_RearrangingFruits;

public class Solution
{
    // Time complexity: O(mlogm + nlogn), Space complexity: O(m + n).
    public static long MinCostToRearrangeFruits(int[] basket1, int[] basket2)
    {
        var counts1 = new SortedDictionary<int, int>();
        var counts2 = new SortedDictionary<int, int>();

        foreach (int fruit in basket1)
        {
            counts1.TryAdd(fruit, 0);
            counts2.TryAdd(fruit, 0);
            counts1[fruit]++;
        }

        foreach (int fruit in basket2)
        {
            counts1.TryAdd(fruit, 0);
            counts2.TryAdd(fruit, 0);
            counts2[fruit]++;
        }

        var excess1 = new List<int>();
        var excess2 = new List<int>();
        int minFruit = int.MaxValue;

        foreach (int fruit in counts1.Keys)
        {
            // It is impossible to make the baskets identical if and only if the combined count of any fruit is odd.
            if ((counts1[fruit] + counts2[fruit]) % 2 != 0) { return -1; }

            // Since the sum is even, the difference should be even too. We only need to swap half of these excess
            // fruits to make the baskets identical.
            int diff = counts1[fruit] - counts2[fruit];
            if (diff > 0) { excess1.AddRange(Enumerable.Repeat(fruit, diff / 2)); }
            if (diff < 0) { excess2.AddRange(Enumerable.Repeat(fruit, -diff / 2)); }

            minFruit = Math.Min(minFruit, fruit);
        }

        int cost = 0;
        for (int i = 0; i != excess1.Count; i++)
        {
            // Fruits can also be swapped by using one with minimum cost on both sides as token.
            cost += Math.Min(2 * minFruit, Math.Min(excess1[i], excess2[excess2.Count - 1 - i]));
        }

        return cost;
    }
}

internal static class Tests
{
    public static void Run()
    {

        Run([1, 1, 2, 2, 3], [4, 4, 3, 3, 3], 3);
    }

    private static void Run(int[] basket1, int[] basket2, long expectedResult)
    {
        long result = Solution.MinCostToRearrangeFruits(basket1, basket2);
        Utilities.PrintSolution((basket1, basket2), result);
        Assert.AreEqual(expectedResult, result);
    }
}
