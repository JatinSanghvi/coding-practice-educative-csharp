// Closest Node to Path in Tree
// ============================
//
// You are given a positive integer, `n`, representing the number of nodes in a tree, numbered from 0 to n-1. You are
// also given a 2D integer array `edges` of length n - 1, where `edges[i]` = [u_i, v_i] indicates that there is a
// bidirectional edge connecting nodes u_i and v_i.
//
// You are also given a 2D integer array `query` of length m, where `query[i]` = [start_i, end_i, node_i].
//
// For each query `i`, find the node on the path between start_i and end_i that is closest to node_i in terms of the
// number of edges.
//
// Return an integer array where the value at index i corresponds to the answer for the ith query.
//
// > Note: If there are multiple such nodes at the same minimum distance, return the one with the smallest index.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 1000
// - `edges.length` == n - 1
// - `edges[i].length` == 2
// - 0 ≤ u_i, v_i ≤ n - 1
// - u_i != v_i
// - 1 ≤ `query.length` ≤ 1000
// - `query[i].length` == 3
// - 0 ≤ start_i, end_i, node_i ≤ n - 1
// - The graph is a tree.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P09_ClosestNodeToPathInTree;

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
