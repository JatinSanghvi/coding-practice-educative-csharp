// Delete N Nodes After M Nodes of a Linked List
// =============================================
//
// Given the `head` of a linked list and two integers, `m` and `n`, remove some specific nodes from the list and
// return the `head` of the modified, linked list. The list should be traversed, and nodes removed as follows:
//
// 1. Start with the `head` node and set it as the `current` node.
// 2. Traverse the next `m` nodes from the `current` node without deleting them.
// 3. Traverse the next `n` nodes and delete them.
// 4. Repeat steps 2 and 3 above until the end of the linked list is reached.
//
// Constraints:
//
// - 1 ≤ `Node` ≤ 10^3, where `Node` is the number of nodes in the list.
// - 1 ≤ `Node.val` ≤ 10^3
// - 1 ≤ `m`, `n` ≤ 500

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P10_DeleteNNodesAfterMNodesOfALinkedList;

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
