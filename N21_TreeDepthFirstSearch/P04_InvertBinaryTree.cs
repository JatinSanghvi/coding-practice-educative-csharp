// Invert Binary Tree
// ==================
//
// Given the root node of a binary tree, transform the tree by swapping each node's left and right subtrees, thus
// creating a mirror image of the original tree. Return the root of the transformed tree.
//
// Constraints:
//
// - 0 ≤ Number of nodes in the tree ≤ 100
// - -1000 ≤ `Node.value` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P04_InvertBinaryTree;

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
