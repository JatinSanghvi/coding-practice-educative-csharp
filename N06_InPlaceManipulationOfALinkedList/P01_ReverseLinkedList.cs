// Reverse Linked List
// ===================
//
// Given the head of a singly linked list, reverse the linked list and return its updated head.
//
// Constraints:
//
// Let `n` be the number of nodes in a linked list.
//
// - 1 ≤ `n` ≤ 500
// - -5000 ≤ `Node.value` ≤ 5000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P01_ReverseLinkedList;

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
