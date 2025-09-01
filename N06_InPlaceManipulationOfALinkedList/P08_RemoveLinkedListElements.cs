// Remove Linked List Elements
// ===========================
//
// You are given the head of a linked list and an integer `k`. Remove all nodes from the linked list where the
// node's value equals `k`, and return the head of the updated list.
//
// Constraints:
//
// - The number of nodes in the linked list is in the range [0, 10^3].
// - 1 ≤ `Node.val` ≤ 50
// - 0 ≤ `k` ≤ 50

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P08_RemoveLinkedListElements;

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
