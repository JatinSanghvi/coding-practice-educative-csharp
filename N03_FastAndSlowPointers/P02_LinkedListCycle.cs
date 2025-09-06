// Linked List Cycle
// =================
//
// Given the `head` of a linked list, determine whether the list contains a cycle. A cycle exists if a node in the list
// can be revisited by continuously following the `next` pointers. Return TRUE if a cycle is present; otherwise, return
// FALSE.
//
// Constraints:
//
// Let `n` be the number of nodes in a linked list.
//
// - 0 ≤ `n` ≤ 500
// - -10^5 ≤ `Node.value` ≤ 10^5

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P02_LinkedListCycle;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static bool DetectCycle(ListNode head)
    {
        ListNode slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (fast == slow)
            {
                return true;
            }
        }

        return false;
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
        Run(Array.Empty<int>(), -1, false);
        Run(new[] { 1, 2, 3, 4, 5 }, -1, false);
        Run(new[] { 1, 2, 3, 4, 5 }, 0, true);
        Run(new[] { 1, 2, 3, 4, 5 }, 4, true);
    }

    private static void Run(int[] values, int cycleIndex, bool expectedResult)
    {
        ListNode head = values.ToList(cycleIndex);
        bool result = Solution.DetectCycle(head);
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

    public static int[] ToArray(this ListNode head)
    {
        List<int> values = new();

        for (ListNode node = head; node != null; node = node.next)
        {
            values.Add(node.val);
        }

        return values.ToArray();
    }
}
