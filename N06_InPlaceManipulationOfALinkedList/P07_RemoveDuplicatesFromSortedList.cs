// Remove Duplicates from Sorted List
// ==================================
//
// Given the `head` of a sorted linked list, remove all duplicates such that each element appears only once, and
// return the list in sorted order.
//
// Constraints:
//
// - 0 ≤ `n` ≤ 300, where `n` is the number of nodes in the list.
// - -100 ≤ `Node.val` ≤ 100
// - The list is guaranteed to be sorted in ascending order.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P07_RemoveDuplicatesFromSortedList;

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
