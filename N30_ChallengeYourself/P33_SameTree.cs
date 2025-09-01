// Same Tree
// =========
//
// Given the roots of two binary trees, `p` and `q`, write a function to check whether or not they are the same. Two
// binary trees are considered the same if they're structurally identical and the nodes have the same value.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [0,100]
//
// - -104≤ `node.data` ≤104

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P33_SameTree;

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
