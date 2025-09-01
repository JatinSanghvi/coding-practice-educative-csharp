// Reverse Nodes in k-Group
// ========================
//
// The task is to reverse the nodes in groups of k in a given linked list, where k is a positive integer, and at
// most the length of the linked list. If any remaining nodes are not part of a group of k, they should remain in
// their original order.
//
// It is not allowed to change the values of the nodes in the linked list. Only the order of the nodes can be
// modified.
//
// > Note: Use only O(1) extra memory space.
//
// Constraints:
//
// Let `n` be the number of nodes in a linked list.
//
// - 1 ≤ `k` ≤ `n` ≤ 500
// - 0 ≤ `Node.value` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P02_ReverseNodesInKGroup;

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
