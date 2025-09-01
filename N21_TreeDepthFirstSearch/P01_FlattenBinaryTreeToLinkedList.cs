// Flatten Binary Tree to Linked List
// ==================================
//
// Given the `root` of a binary tree, the task is to flatten the tree into a linked list using the same `TreeNode`
// class. The left child pointer of each node in the linked list should always be NULL, and the right child pointer
// should point to the next node in the linked list. The nodes in the linked list should be in the same order as that of
// the preorder traversal of the given binary tree.
//
// Constraints:
//
// - -100 ≤ `Node.data` ≤ 100.
// - The tree contains nodes in the range [1, 500].

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N21_TreeDepthFirstSearch.P01_FlattenBinaryTreeToLinkedList;

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
