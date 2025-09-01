// Optimize Water Distribution in a Village
// ========================================
//
// There are n houses in a village, and we want to supply water to every house. To do this, we have two options:
//
// 1. Build a well directly at a house: The costs for building wells are given in the wells array, where `wells[i - 1]
//    `represents the cost to build a well at house `i` (houses are numbered from 1 to n, but the array is 0-indexed).
//
// 2. Lay water pipes to connect two houses: Allowing one to receive water from the other. The costs for building these
//    connections are given in the `pipes` array. Each pipe entry is written as `[house1, house2, cost]`, meaning it
//    costs to construct a pipe connecting `house1` and `house2`. The connection is *two-way* (water can flow in both
//    directions).
//
// In the given data, multiple pipe entries may connect the same pair of houses, but with different costs. Each entry
// represents an available option; you may choose the most cost-effective one.
//
// Your task is to determine the minimum total cost to ensure every house gets access to water, either by building a
// well directly at it or connecting it via pipes to another house with access to water.
//
// Constraints:
//
// - 2 <= n <= 10^4
// - `wells.length` == n
// - 0 <= `wells[i]` <= 10^5
// - 1 <= `pipes.length` <= 10^4
// - `pipes[j].length` == 3
// - 1 <= `house1_j`, `house2_j` <= n
// - 0 <= `cost_j` <= 10^5
// - `house1_j` != `house2_j`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P12_OptimizeWaterDistributionInAVillage;

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
