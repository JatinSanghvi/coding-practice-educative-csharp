// Reverse Linked List II
// ======================
//
// Given a singly linked list with n nodes and two positions, `left` and `right`, the objective is to reverse the
// nodes of the list from `left` to `right`. Return the modified list.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 500
// - -5000 ≤ `node.val` ≤ 5000
// - 1 ≤ `left` ≤ `right` ≤ `n`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P03_ReverseLinkedListII;

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
