// Swapping Nodes in a Linked List
// ===============================
//
// Given the `head` of a linked list and an integer, `k`, return the head of the linked list after swapping the
// values of the kth node from the beginning and the kth node from the end of the linked list.
//
// > Note: We'll number the nodes of the linked list starting from 1 to n.
//
// Constraints:
//
// - The linked list will have `n` number of nodes.
// - 1 ≤ `k` ≤ `n` ≤ 500
// - -5000 ≤ `Node.value` ≤ 5000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P05_SwappingNodesInALinkedList;

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
