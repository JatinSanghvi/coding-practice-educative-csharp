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
    // Time complexity: O(n+e), Space complexity: O(n) where e = number of edges.
    public static bool ValidPath(int n, int[][] graph, int source, int destination)
    {
        var parents = new int[n];
        var ranks = new int[n];

        for (int i = 0; i != n; i++)
        {
            parents[i] = i;
        }

        foreach (int[] edge in graph)
        {
            Union(edge[0], edge[1]);
        }

        return Find(source) == Find(destination);

        void Union(int x1, int x2)
        {
            int p1 = Find(x1);
            int p2 = Find(x2);

            if (p1 == p2) { return; }

            if (ranks[p1] == ranks[p2]) { ranks[p1]++; }
            if (ranks[p1] >= ranks[p2]) { parents[p2] = p1; }
            else { parents[p1] = p2; }
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
        Run(4, [[0, 1], [1, 2]], 0, 2, true);
        Run(4, [[0, 1], [1, 2]], 2, 0, true);
        Run(4, [[0, 1], [1, 2]], 1, 3, false);
        Run(4, [[0, 1], [2, 3]], 1, 3, false);
    }

    private static void Run(int n, int[][] graph, int source, int destination, bool expectedResult)
    {
        bool result = Solution.ValidPath(n, graph, source, destination);
        Utilities.PrintSolution((n, graph, source, destination), result);
        Assert.AreEqual(expectedResult, result);
    }
}
