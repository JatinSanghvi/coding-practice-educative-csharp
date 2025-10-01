// Two City Scheduling
// ===================
//
// A recruiter plans to hire n people and conducts their interviews at two different locations of the company. He
// evaluates the cost of inviting candidates to both these locations. The plan is to invite 50% at one location, and the
// rest at the other location, keeping costs to a minimum.
//
// We are given an array, `costs`, where `costs[i] = [aCost_i, bCost_i]`, the cost of inviting the i-th person to City A
// is `aCost_i`, and the cost of inviting the same person to City B is `bCost_i`.
//
// You need to determine the minimum cost to invite all the candidates for the interview such that exactly n/2 people
// are invited in each city.
//
// Constraints:
//
// - 2 ≤ `costs.length` ≤ 100
// - `costs.length` is even
// - 1 ≤ `aCost_i`, `bCost_i` ≤ 1000

using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N12_GreedyTechniques.P04_TwoCityScheduling;

public class Solution
{
    // Time complexity: O(n*logn), Space complexity: O(1).
    public static int TwoCityScheduling(int[][] costs)
    {
        Array.Sort(costs, (cost1, cost2) => (cost1[0] - cost1[1]) - (cost2[0] - cost2[1]));

        int total = 0;
        for (int i = 0; i != costs.Length / 2; i++) { total += costs[i][0]; }
        for (int i = costs.Length / 2; i != costs.Length; i++) { total += costs[i][1]; }
        return total;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2], [3, 5], [6, 7], [10, 8]], 19);
    }

    private static void Run(int[][] costs, int expectedResult)
    {
        int[][] costsCopy = costs.ToArray();
        int result = Solution.TwoCityScheduling(costs);
        Utilities.PrintSolution(costsCopy, result);
        Assert.AreEqual(expectedResult, result);
    }
}
