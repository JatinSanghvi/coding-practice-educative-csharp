// Reverse Nodes in Even Length Groups
// ===================================
//
// Given the head of a linked list, the nodes in it are assigned to each group in a sequential manner. The length
// of these groups follows the sequence of natural numbers. Natural numbers are positive whole numbers denoted by
// (1, 2, 3, 4...).
//
// In other words:
//
// - The 1st node is assigned to the first group.
// - The 2nd and 3rd nodes are assigned to the second group.
// - The 4th, 5th, and 6th nodes are assigned to the third group, and so on.
//
// Your task is to reverse the nodes in each group with an even number of nodes and return the head of the
// modified linked list.
//
// > Note: The length of the last group may be less than or equal to 1 + the length of the second to the last
// > group.
//
// Constraints:
//
// - 1 ≤ Number of nodes ≤ 500
// - 0 ≤ `Node.val` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P06_ReverseNodesInEvenLengthGroups;

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
