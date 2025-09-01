// Linked List Cycle II
// ====================
//
// Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.
//
// A cycle exists in a linked list if there is some node in the list that can be reached again by continuously following
// the `next` pointer. Internally, `pos` denotes the node's index to which the tail's next pointer is connected.
//
// Constraints:
//
// - The number of the nodes in the list is in the range [0,104].
//
// - -105≤ `Node.value` ≤105
//
// - `pos` is -1 or a valid index in the linked list.
//
// > Note: The `pos` parameter isn't passed as a parameter.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P27_LinkedListCycleII;

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
