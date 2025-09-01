// Binary Tree Right Side View
// ===========================
//
// You are given a root of a binary tree that has `n` number of nodes. You have to return the right-side view in the
// form of a list.
//
// A right-side view of a binary tree is the data of the nodes that are visible when the tree is viewed from the right
// side.
//
// Constraints:
//
// - 0 ≤ `n` ≤ 100
// - -100 ≤ `Node.data` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P08_BinaryTreeRightSideView;

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
