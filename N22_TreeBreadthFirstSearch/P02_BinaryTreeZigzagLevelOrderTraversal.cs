// Binary Tree Zigzag Level Order Traversal
// ========================================
//
// Given a binary tree, return its zigzag level order traversal. The zigzag level order traversal corresponds to
// traversing nodes from left to right for one level, and then right to left for the next level, and so on, reversing
// direction after every level.
//
// Constraints:
//
// - The number of nodes in the tree is in the range 0 to 500.
// - -100 ≤ `node.data` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P02_BinaryTreeZigzagLevelOrderTraversal;

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
