// Delete Nodes And Return Forest
// ==============================
//
// Given the root of a binary tree where each node has a unique value, your task is to delete all nodes with values
// specified in the `deleteNodes` list. After performing the deletions, the tree will split into a forest---a collection
// of disjoint trees. Return the roots of the remaining trees in the forest in any order.
//
// Constraints:
//
// - 0 ≤ `nodes` ≤ 100
//
// - 1 ≤ `nodes.value` ≤ 1000
//
// - 0 ≤ `deleteNodes.length` ≤ 100
//
// - 1 ≤ `deleteNodes[i]` ≤ 1000
//
// > Note: Both `nodes` and `deleteNodes[i]` will have distinct values.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P14_DeleteNodesAndReturnForest;

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
