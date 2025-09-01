// Binary Tree Paths
// =================
//
// Given the `root` of a binary tree, return all paths from the root to the leaf nodes in any order. Each path should be
// represented as a string of node values, separated by arrows (`→`), where a leaf is defined as a node with no
// children.
//
// Constraints:
//
// - 1 ≤ `nodes` ≤ 100
// - -10^4 ≤ `nodes.data` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N13_Backtracking.P07_BinaryTreePaths;

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
