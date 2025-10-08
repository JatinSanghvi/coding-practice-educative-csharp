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

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P01_RedundantConnection;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(n).
    public static int[] RedundantConnection(int[][] edges)
    {
        UnionFind uf = new UnionFind(edges.Length + 1);

        foreach (int[] edge in edges)
        {
            if (!uf.Union(edge[0], edge[1])) { return edge; }
        }

        throw new ArgumentException();
    }
}

public class UnionFind
{
    private readonly int[] parents;
    private readonly int[] ranks;

    public UnionFind(int n)
    {
        parents = new int[n];
        ranks = new int[n];

        for (int i = 0; i != n; i++)
        {
            parents[i] = i;
            ranks[i] = 1;
        }
    }

    public int Find(int x)
    {
        if (parents[x] != x)
        {
            parents[x] = Find(parents[x]);
        }

        return parents[x];
    }

    public bool Union(int x1, int x2)
    {
        int p1 = Find(x1);
        int p2 = Find(x2);

        if (p1 == p2) { return false; }

        if (ranks[p1] >= ranks[p2])
        {
            parents[p2] = p1;
            ranks[p1] += ranks[p2];
        }
        else
        {
            parents[p1] = p2;
            ranks[p2] += ranks[p1];
        }

        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2], [2, 3], [3, 1], [3, 4]], [3, 1]);
    }

    private static void Run(int[][] edges, int[] expectedResult)
    {
        int[] result = Solution.RedundantConnection(edges);
        Utilities.PrintSolution(edges, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
