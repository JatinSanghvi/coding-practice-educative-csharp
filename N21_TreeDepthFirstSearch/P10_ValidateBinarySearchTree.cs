// Validate Binary Search Tree
// ===========================
//
// Given the root of a binary tree, check whether it is a valid binary search tree (BST).
//
// A binary tree is a valid BST if for every node:
//
// - The left subtree of a node contains only nodes with keys less than the node's key.
//
// - The right subtree of a node contains only nodes with keys greater than the node's key.
//
// - Both the left and right subtrees are valid BSTs.
//
// Constraints:
//
// - -10^4 ≤ `Node.data` ≤ 10^4
//
// - The tree contains nodes in the range [1, 500].

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P10_ValidateBinarySearchTree;

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
