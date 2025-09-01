// Maximum Depth of Binary Tree
// ============================
//
// You are given the `root` of a binary tree, and your task is to determine the maximum depth of this tree. The maximum
// depth of a binary tree is determined by the count of nodes found on the longest path from the root node to the
// farthest leaf node.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [1, 500].
//
// - -100 ≤ `Node.data` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P16_MaximumDepthOfBinaryTree;

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
