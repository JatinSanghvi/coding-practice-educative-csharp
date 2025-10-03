// All Paths From Source to Target
// ===============================
//
// You are given a directed acyclic graph (DAG) with n nodes, labeled from 0 to n - 1. The graph is represented as an
// adjacency list, where `graph[i]` is a list of all nodes to which node `i` has a directed edge.
//
// Your task is to find all possible paths from node 0 (the source) to node n - 1 (the target) and return them as a list
// of paths. Each path should be represented as a list of node indexes.
//
// > Note: You may return the answer in any order.
//
// Constraints:
//
// - 2 ≤ n ≤ 15
// - 0 ≤ `graph[i][j]` < n
// - All nodes in `graph[i]` are unique.
// - The graph is guaranteed to be a DAG (no cycles).
// - There are no self-loops (i.e., `graph[i]` does not contain `i`).

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P11_AllPathsFromSourceToTarget;

public class Solution
{
    // Time complexity: O(edges), Space complexity: O(vertices).
    public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var paths = new List<IList<int>>();
        var path = new LinkedList<int>();
        Solve(0);
        return paths;

        void Solve(int i)
        {
            path.AddLast(i);

            if (i == graph.Length - 1)
            {
                paths.Add(path.ToList());
            }
            else
            {
                foreach (int j in graph[i])
                {
                    Solve(j);
                }
            }

            path.RemoveLast();
        }
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([[1, 2, 3], [4], [4], [4], []], [[0, 1, 4], [0, 2, 4], [0, 3, 4]]);
    }

    private static void Run(int[][] graph, int[][] expectedResult)
    {
        int[][] result = Solution.AllPathsSourceTarget(graph).Select(p => p.ToArray()).ToArray();
        Utilities.PrintSolution(graph, result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
