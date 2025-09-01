// Longest Cycle in a Graph
// ========================
//
// You are given a directed graph with `n` nodes, labeled from `0` to `n - 1`. Each node in the graph has at most one
// outgoing edge.
//
// The graph is described using a 0-indexed integer array `edges` of length `n`, where:
//
// - `edges[i]` represents a directed edge from node `i` to node `edges[i]`.
// - If node `i` has no outgoing edge, then `edges[i] == -1`.
//
// Your task is to find the longest cycle length in the graph. If no cycle exists, return `-1`.
//
// > Note: A cycle is defined as a path that starts and ends at the same node, following the direction of the edges.
//
// Constraints:
//
// - `n` == `edges.length`
// - 2 ≤ `n` ≤ 10^5
// - -1 ≤ `edges[i]` ≤ `n`
// - `edges[i]` ≠ `i`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P14_LongestCycleInAGraph;

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
