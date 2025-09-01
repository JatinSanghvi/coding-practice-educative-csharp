// Inorder Successor in BST
// ========================
//
// You are given the root node of a binary search tree and a specific node `p`. Your task is to return the inorder
// successor of this `p` node. If there is no inorder successor of the given node, return NULL.
//
// > Note: The inorder successor of `p` is the node with the smallest value greater than `p.data` in the binary search
// > tree.
//
// Constraints:
//
// - The tree contains nodes in the range [1, 500].
//
// - -10^4 ≤ `Node.data` ≤ 10^4
//
// - All Nodes will have unique values.
//
// - `p` should exist in the tree.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P12_InorderSuccessorInBST;

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
