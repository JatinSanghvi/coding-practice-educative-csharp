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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P02_NumberOfConnectedComponentsInAnUndirectedGraph;

public class Solution
{
    // Time complexity: O(v+e), Space complexity: O(v+e).
    public static int CountComponents(int n, int[][] edges)
    {
        var graph = new List<int>[n];
        for (int node = 0; node != n; node++)
        {
            graph[node] = new List<int>();
        }

        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var visited = new bool[n];
        int components = 0;

        for (int node = 0; node != n; node++)
        {
            if (!visited[node])
            {
                components++;
                Visit(node);
            }
        }

        return components;

        void Visit(int node1)
        {
            visited[node1] = true;
            foreach (int node2 in graph[node1])
            {
                if (!visited[node2])
                {
                    Visit(node2);
                }
            }
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(1, [], 1);
        Run(5, [[0, 1], [4, 3]], 3);
        Run(5, [[1, 3], [2, 4], [4, 3]], 2);
    }

    private static void Run(int n, int[][] edges, int expectedResult)
    {
        int result = Solution.CountComponents(n, edges);
        Utilities.PrintSolution((n, edges), result);
        Assert.AreEqual(expectedResult, result);
    }
}
