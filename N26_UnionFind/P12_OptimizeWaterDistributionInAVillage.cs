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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P12_OptimizeWaterDistributionInAVillage;

public class Solution
{
    // Time complexity: O((w+p)*log(w+p)), Space complexity: O(w+p).
    public int MinCostToSupplyWater(int n, int[] wells, int[][] pipes)
    {
        // Wells can also be considered as pipes from the main water source. Since at least, one well will be involved,
        // the water source will be part of the pipeline network. The task, hence becomes of finding the minimum
        // spanning tree.
        var costs = new List<(int cost, int house1, int house2)>();
        for (int i = 0; i != wells.Length; i++)
        {
            costs.Add((wells[i], 0, i + 1));
        }

        foreach (int[] pipe in pipes)
        {
            costs.Add((pipe[2], pipe[0], pipe[1]));
        }

        costs.Sort();

        var parents = new int[n + 1];
        var ranks = new int[n + 1];

        for (int i = 0; i != n + 1; i++)
        {
            parents[i] = i;
        }

        int connects = 0;
        int minCost = 0;

        for (int i = 0; connects != n; i++)
        {
            (int cost, int house1, int house2) = costs[i];
            if (Union(house1, house2))
            {
                connects++;
                minCost += cost;
            }
        }

        return minCost;

        bool Union(int x1, int x2)
        {
            int p1 = Find(x1);
            int p2 = Find(x2);

            if (p1 == p2) { return false; }

            if (ranks[p1] == ranks[p2]) { ranks[p1]++; }
            if (ranks[p1] >= ranks[p2]) { parents[p2] = p1; }
            else { parents[p1] = p2; }
            return true;
        }

        int Find(int x)
        {
            if (parents[x] != x) { parents[x] = Find(parents[x]); }
            return parents[x];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(2, [1, 4], [[1, 2, 3]], 4);
        Run(2, [1, 2], [[1, 2, 3]], 3);
    }

    private static void Run(int n, int[] wells, int[][] pipes, int expectedResult)
    {
        int result = new Solution().MinCostToSupplyWater(n, wells, pipes);
        Utilities.PrintSolution((n, wells, pipes), result);
        Assert.AreEqual(expectedResult, result);
    }
}
