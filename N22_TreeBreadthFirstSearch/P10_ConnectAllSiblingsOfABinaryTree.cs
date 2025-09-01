// Connect All Siblings of a Binary Tree
// =====================================
//
// Given the root of a perfect binary tree, where each node is equipped with an additional pointer, `next`, connect all
// nodes from left to right. Do so in such a way that the `next` pointer of each node points to its immediate right
// sibling except for the rightmost node, which points to the first node of the next level.
//
// The `next` pointer of the last node of the binary tree (i.e., the rightmost node of the last level) should be set to
// NULL.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [0, 500].
// - -1000 ≤ `Node.data` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P10_ConnectAllSiblingsOfABinaryTree;

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
