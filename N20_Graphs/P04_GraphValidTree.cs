// Graph Valid Tree
// ================
//
// Given `n` as the number of nodes and an array of the `edges` of a graph, find out if the graph is a valid tree. The
// nodes of the graph are labeled from 0 to n - 1, and `edges[i] = [x, y]` represents an undirected edge connecting the
// nodes x and y of the graph.
//
// A graph is a valid tree when all the nodes are connected and there is no cycle between them.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 1000
// - 0 ≤ `edges.length` ≤ 2000
// - `edges[i].length` = 2
// - 0 ≤ x, y < `n`
// - x != y
// - There are no repeated edges.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P04_GraphValidTree;

public class Solution
{
    // Time complexity: O(e), Space complexity: O(n).
    public static bool IsGraphAValidTree(int n, int[][] edges)
    {
        if (edges.Length != n - 1) { return false; }

        var parents = new int[n];
        var ranks = new int[n];

        for (int i = 0; i != n; i++)
        {
            parents[i] = i;
        }

        foreach (int[] edge in edges)
        {
            if (!Union(edge[0], edge[1]))
            {
                return false;
            }
        }

        return true;

        bool Union(int node1, int node2)
        {
            int parent1 = Find(node1);
            int parent2 = Find(node2);

            if (parent1 == parent2) { return false; }

            if (ranks[parent1] == ranks[parent2]) { ranks[parent1]++; }
            if (ranks[parent1] > ranks[parent2]) { parents[parent2] = parent1; }
            else { parents[parent1] = parent2; }

            return true;
        }

        int Find(int node)
        {
            if (parents[node] != node)
            {
                parents[node] = Find(parents[node]);
            }

            return parents[node];
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(4, [[0, 1], [0, 2], [1, 2]], false);
        Run(4, [[0, 1], [0, 2], [1, 3]], true);
    }

    private static void Run(int n, int[][] edges, bool expectedResult)
    {
        bool result = Solution.IsGraphAValidTree(n, edges);
        Utilities.PrintSolution((n, edges), result);
        Assert.AreEqual(expectedResult, result);
    }
}
