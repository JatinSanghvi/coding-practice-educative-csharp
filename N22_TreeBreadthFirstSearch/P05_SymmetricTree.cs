// Symmetric Tree
// ==============
//
// Given the root of a binary tree, check whether it is a symmetric tree. A symmetric tree refers to a tree that is a
// mirror of itself, i.e., symmetric around its root.
//
// Constraints:
//
// - The tree contains nodes in the range [1, 500].
// - -10^3 ≤ `Node.data` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P05_SymmetricTree;

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
