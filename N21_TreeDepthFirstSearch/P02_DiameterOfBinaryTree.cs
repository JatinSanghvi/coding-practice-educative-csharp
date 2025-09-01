// Diameter of Binary Tree
// =======================
//
// Given a binary tree, you need to compute the length of the tree's diameter. The diameter of a binary tree is the
// length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
//
// > Note: The length of the path between two nodes is represented by the number of edges between them.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [1, 500].
// - -100 ≤ `Node.value` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P02_DiameterOfBinaryTree;

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
