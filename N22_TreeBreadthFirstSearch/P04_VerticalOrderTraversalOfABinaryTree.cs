// Vertical Order Traversal of a Binary Tree
// =========================================
//
// Find the vertical order traversal of a binary tree when the root of the binary tree is given. In other words, return
// the values of the nodes from top to bottom in each column, column by column from left to right. If there is more than
// one node in the same column and row, return the values from left to right.
//
// Constraints:
//
// - The number of nodes in the tree is in the range `[1, 500]`.
// - -1000 ≤ `Node.data` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P04_VerticalOrderTraversalOfABinaryTree;

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
