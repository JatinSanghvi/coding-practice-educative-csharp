// Split Linked List in Parts
// ==========================
//
// You are given `head` of a singly linked list and an integer, `k`. Your task is to split the linked list into
// `k` consecutive parts.
//
// - Each part should have a size as equal as possible, with the difference between any two parts being at most 1.
// - If the list cannot be evenly divided, the earlier parts should have more nodes than the later ones.
// - Any parts that cannot be filled with nodes should be represented as NULL.
// - The parts must appear in the same order as in the input-linked list.
//
// Return an array of the `k` parts, maintaining the specified conditions.
//
// Constraints:
//
// - The number of nodes in the list is in the range [0, 10^3].
// - 0 ≤ `Node.val` ≤ 10^3
// - 1 ≤ `k` ≤ 50

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P09_SplitLinkedListInParts;

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
