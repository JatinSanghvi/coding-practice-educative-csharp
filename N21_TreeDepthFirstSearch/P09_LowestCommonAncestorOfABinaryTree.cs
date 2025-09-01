// Lowest Common Ancestor of a Binary Tree
// =======================================
//
// Given the root node of a binary tree with n nodes, your task is to find the lowest common ancestor of two of its
// nodes, `p` and `q`.
//
// > Note: The lowest common ancestor of two nodes, `p` and `q`, is defined as the lowest node in the binary tree that
// > has both `p` and `q` as descendants.
//
// > A node can also be a descendant of itself. For example, if `q` is a descendant of `p`, and we know that `p` is a
// > descendant of itself, then `p` will be the lowest common ancestor of `p` and `q`.
//
// Constraints:
//
// - 2 ≤ n ≤ 500
// - All `Node.data` are unique.
// - `p` != `q`
// - `p` and `q` exist in the tree.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P09_LowestCommonAncestorOfABinaryTree;

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
