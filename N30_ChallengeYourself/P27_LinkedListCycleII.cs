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
// - The number of the nodes in the list is in the range [0,10^4].
// - -10^5 ≤ `Node.value` ≤ 10^5
// - `pos` is -1 or a valid index in the linked list.
//
// > Note: The `pos` parameter isn't passed as a parameter.

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P27_LinkedListCycleII;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode DetectCycle(ListNode head)
    {
        ListNode superHead = new ListNode(0) { next = head };
        ListNode slow = superHead, fast = superHead;

        do
        {
            slow = slow.next;
            fast = fast.next?.next;
        }
        while (fast != null && fast != slow);

        if (fast == null) { return null; }

        slow = superHead;

        do
        {
            slow = slow.next;
            fast = fast.next;
        }
        while (fast != slow);

        return fast;
    }
}

public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}

internal static class Tests
{
    public static void Run()
    {
        Run(Array.Empty<int>(), -1, null);
        Run(new[] { 1, 2, 3, 4, 5 }, -1, null);
        Run(new[] { 1, 2, 3, 4, 5 }, 0, 1);
        Run(new[] { 1, 2, 3, 4, 5 }, 4, 5);
    }

    private static void Run(int[] values, int cycleIndex, int? expectedResult)
    {
        ListNode head = values.ToList(cycleIndex);
        int? result = Solution.DetectCycle(head)?.val;
        Utilities.PrintSolution((values, cycleIndex), result);
        Assert.AreEqual(expectedResult, result);
    }

    public static ListNode ToList(this int[] values, int cycleIndex)
    {
        ListNode cycleNode = null;
        ListNode parent = new();
        ListNode node = parent;

        for (int index = 0; index < values.Length; index++)
        {
            node.next = new ListNode(values[index]);
            node = node.next;

            if (index == cycleIndex)
            {
                cycleNode = node;
            }
        }

        node.next = cycleNode;
        return parent.next;
    }
}
