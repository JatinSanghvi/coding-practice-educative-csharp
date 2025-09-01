// Reorder Routes to Make All Paths Lead to the City Zero
// ======================================================
//
// There are `n` cities labeled from 0 to n - 1, connected by n - 1 roads, so there is only one route between any two
// cities. This road network forms a tree structure.
//
// Last year, the Ministry of transport made all roads one-way due to their narrow width. These roads are represented as
// connections, where each entry `connections[i] = [a_i, b_i]` means there is a road going from city `a_i` to city
// `b_i`.
//
// This year, a major event will occur in the capital city (city 0), and people from all other cities must reach it.
// Your task is to reorient some roads so every city has a valid path leading to city 0. Return the minimum number of
// roads that must be changed to achieve this.
//
// > Note: A solution is guaranteed to exist, meaning that every city can eventually reach city 0 after reordering.
//
// Constraints:
//
// - 2 ≤ `n` ≤ 5 ∗ 10^4
// - `connections.length` == n - 1
// - `connections[i].length` == 2
// - 0 ≤ a_i, b_i ≤ n - 1

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P12_ReorderRoutesToMakeAllPathsLeadToTheCityZero;

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
