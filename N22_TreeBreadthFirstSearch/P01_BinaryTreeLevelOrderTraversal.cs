// Binary Tree Level Order Traversal
// =================================
//
// Given the root of a binary tree, display the values of its nodes while performing a level order traversal. Return the
// node values for all levels in a string separated by the character `:`. If the tree is empty, i.e., the number of
// nodes is 0, then return "None" as the output.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [0, 500].
// - -10^3 ≤ `Node.data` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P01_BinaryTreeLevelOrderTraversal;

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
