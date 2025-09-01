// Two Sum IV - Input Is a BST
// ===========================
//
// Given the `root` of a binary search tree and an integer `k`, determine whether there are two elements in the BST
// whose sum equals `k`. Return TRUE if such elements exist or FALSE otherwise.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [1, 10^3].
// - -10^3 ≤ `Node.data` ≤ 10^3
// - `root` is guaranteed to be a valid binary search tree.
// - -10^4 ≤ `k` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P07_TwoSumIVInputIsABST;

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
