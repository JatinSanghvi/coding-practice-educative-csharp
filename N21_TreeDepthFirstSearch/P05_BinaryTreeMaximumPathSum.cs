// Binary Tree Maximum Path Sum
// ============================
//
// Given the root of a binary tree, return the maximum sum of any non-empty path.
//
// A path in a binary tree is defined as follows:
//
// - A sequence of nodes in which each pair of adjacent nodes must have an edge connecting them.
// - A node can only be included in a path once at most.
// - Including the root in the path is not compulsory.
//
// You can calculate the path sum by adding up all node values in the path. To solve this problem, calculate the maximum
// path sum given the root of a binary tree so that there won't be any greater path than it in the tree.
//
// Constraints:
//
// - 1 ≤ Number of nodes in the tree ≤ 500.
// - -1000 ≤ `Node.value` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P05_BinaryTreeMaximumPathSum;

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
