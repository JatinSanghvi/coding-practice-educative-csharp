// Populating Next Right Pointers in Each Node
// ===========================================
//
// Given a perfect binary tree, where each node contains an additional pointer called `next`. This pointer is initially
// set to `NULL` for all nodes. Your task is to connect all nodes of the same hierarchical level by setting the `next`
// pointer to its immediate right node.
//
// The `next` pointer of the rightmost node at each level is set to NULL.
//
// Constraints:
//
// - The number of nodes in the tree is in the range [0, 500].
// - -1000 ≤ `Node.data` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N22_TreeBreadthFirstSearch.P03_PopulatingNextRightPointersInEachNode;

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
