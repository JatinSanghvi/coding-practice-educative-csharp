// Kth Smallest Element in a BST
// =============================
//
// Given the root node of a binary search tree and an integer value `k`, return the kth smallest value in the tree.
//
// Constraints:
//
// - The number of nodes in the tree is n.
// - 1 ≤ k ≤ n ≤ 500
// - 0 ≤ `Node.data` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P17_KthSmallestElementInABST;

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
