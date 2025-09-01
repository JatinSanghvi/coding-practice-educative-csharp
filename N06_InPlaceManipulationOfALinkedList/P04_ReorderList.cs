// Reorder List
// ============
//
// Given the head of a singly linked list, reorder the list as if it were folded on itself. For example, if the
// list is represented as follows:
//
// L0 → L1 → L2 → ... → Ln-2 → Ln-1 → Ln
//
// This is how you'll reorder it:
//
// L0 → Ln → L1 → Ln-1 → L2 → Ln-2 → ...
//
// You don't need to modify the values in the list's nodes; only the links between nodes need to be changed.
//
// Constraints:
//
// - The range of number of nodes in the list is [1, 500]
// - -5000 ≤ `Node.value` ≤ 5000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P04_ReorderList;

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
