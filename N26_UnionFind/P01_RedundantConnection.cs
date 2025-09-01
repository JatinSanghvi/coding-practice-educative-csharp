// Redundant Connection
// ====================
//
// We're given an undirected graph consisting of n nodes. The graph is represented as an array called `edges`, of length
// n, where `edges[i] = [a, b]` indicates that there is an edge between nodes `a` and `b` in the graph.
//
// Return an edge that can be removed to make the graph a tree of n nodes. If there are multiple candidates for removal,
// return the edge that occurs last in `edges`.
//
// Constraints:
//
// - 3 ≤ n ≤ 100
// - `edges.length` = n
// - `edges[i].length` = 2
// - 1 ≤ `a` < `b` ≤ n
// - a ≠ b
// - There are no repeated edges.
// - The given graph is connected.
// - The graph contains only one cycle.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P01_RedundantConnection;

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
