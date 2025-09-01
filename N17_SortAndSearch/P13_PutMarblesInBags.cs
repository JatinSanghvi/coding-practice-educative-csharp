// Put Marbles in Bags
// ===================
//
// You are given `k` bags and a 0-indexed integer array, `weights`, where `weights[i]` represents the weight of the i-th
// marble.
//
// Your task is to divide the marbles into the `k` bags according to the following rules:
//
// 1. No bag can be empty.
// 2. If the i-th marble and the j-th marble are placed in the same bag, then all marbles with indexes between `i` and
//    `j` (inclusive) must also be placed in that same bag.
// 3. If a bag contains all the marbles from index `i` to `j` (inclusive), its cost is calculated as `weights[i] +
//    weights[j]`.
//
// After distributing the marbles, the sum of the costs of all the `k` bags is called the score.
//
// Return the difference between the maximum and minimum scores achievable by distributing the marbles into the `k`
// bags.
//
// Constraints:
//
// - 1 ≤ `k` ≤ `weights.length` ≤ 10^5
// - 1 ≤ `weights[i]` ≤ 10^9

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P13_PutMarblesInBags;

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
