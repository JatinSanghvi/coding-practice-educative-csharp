// Clone Graph
// ===========
//
// You are given a reference to a single node in an undirected, connected graph. Your task is to create a deep copy of
// the graph starting from the given node. A deep copy means creating a new instance of every node in the graph with the
// same data and edges as the original graph, such that changes in the copied graph do not affect the original graph.
//
// Each node in the graph contains two properties:
//
// - `data`: The value of the node, which is the same as its index in the adjacency list.
// - `neighbors`: A list of connected nodes, representing all the nodes directly linked to this node.
//
// However, in the test cases, a graph is represented as an adjacency list to understand node relationships, where each
// index in the list represents a node (using 1-based indexing). For example, for `[[2,3],[1,3],[1,2]]`, there are three
// nodes in the graph:
//
// 1st node (data = 1): Neighbors are 2nd node (data = 2) and 3rd node (data = 3).
// 2nd node (data = 2): Neighbors are 1st node (data = 1) and 3rd node (data = 3).
// 3rd node (data = 3): Neighbors are 1st node (data = 1) and 2nd node (data = 2).
//
// The adjacency list will be converted to a graph at the backend and the first node of the graph will be passed to your
// code.
//
// Constraints:
//
// - 0 ≤ Number of nodes ≤ 100
// - 1 ≤ `Node.data` ≤ 100
// - `Node.data` is unique for each node.
// - The graph is undirected, i.e., there are no self-loops or repeated edges.
// - The graph is connected, i.e., any node can be visited from a given node.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N20_Graphs.P03_CloneGraph;

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
