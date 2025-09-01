// Build Binary Tree from Preorder and Inorder Traversal
// =====================================================
//
// Create a binary tree from two integer arrays, `pOrder` and `iOrder`, where `pOrder` represents a preorder traversal
// of a binary tree, and `iOrder` represents an inorder traversal of the same tree.
//
// Constraints:
//
// - 1 ≤ `pOrder.length`, `iOrder.length` ≤ 1000
// - `iOrder.length` == `pOrder.length`
// - -1000 ≤ `pOrder[i]`, `iOrder[i]` ≤ 1000
// - `pOrder` and `iOrder` consist of unique values.
// - Each value of `iOrder` also appears in `pOrder` and vice versa.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P07_BuildBinaryTreeFromPreorderAndInorderTraversal;

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
