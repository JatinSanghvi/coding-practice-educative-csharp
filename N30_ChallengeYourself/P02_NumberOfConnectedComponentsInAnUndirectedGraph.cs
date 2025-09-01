// Number of Connected Components in an Undirected Graph
// =====================================================
//
// For a given integer, `n`, and an array, `edges`, return the number of connected components in a graph containing `n`
// nodes.
//
// > Note: The array `edges[i] = [x, y]` indicates that there's an edge between `x` and `y` in the graph.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 2000
// - 1 ≤ `edges.length` ≤ 1000
// - `edges[i].length` == 2
// - 0 ≤ `x`, `y` < `n`
// - `x` ≠ `y`
// - There are no repeated edges.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P02_NumberOfConnectedComponentsInAnUndirectedGraph;

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
