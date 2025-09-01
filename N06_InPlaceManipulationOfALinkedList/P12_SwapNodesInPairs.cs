// Swap Nodes in Pairs
// ===================
//
// Given a singly linked list, swap every two adjacent nodes of the linked list. After the swap, return the head
// of the linked list.
//
// > Note: Solve the problem without modifying the values in the list's nodes. In other words, only the nodes
// themselves can be changed.
//
// Constraints:
//
// - The number of nodes in the list is in the range [0, 100].
// - 0 ≤ `Node.value` ≤ 100

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P12_SwapNodesInPairs;

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
