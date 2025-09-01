// Find if Path Exists in Graph
// ============================
//
// Given a 2D list, `edges`,  which represents a bidirectional graph. Each vertex is labeled from 0 to n-1, and each
// edge in the graph is represented as a pair, [x_i, y_i], showing a bidirectional edge between x_i and y_i. Each pair
// of vertices is connected by at most one edge, and no vertex is connected to itself.
//
// Determine whether a valid path exists from the `source` vertex to the `destination` vertex. If it exists, return
// TRUE; otherwise, return FALSE.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 10^2
// - 0 ≤ `edges.length` ≤ n (n - 1) / 2
// - `edges[i].length` = 2
// - 0 ≤ x_i, y_i ≤ n - 1
// - x_i ≠ y_i
// - 0 ≤ `source`, `destination` ≤ n - 1
// - There are no duplicate edges.
// - There are no self-edges.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P09_FindIfPathExistsInGraph;

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
