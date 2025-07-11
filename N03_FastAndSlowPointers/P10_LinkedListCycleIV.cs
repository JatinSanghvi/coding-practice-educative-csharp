// Linked List Cycle IV
// ====================
// 
// Given the head of a singly linked list, implement a function to detect and remove any cycle present in the list. A
// cycle occurs when a node's `next` pointer links back to a previous node, forming a loop within the list.
// 
// The function must modify the linked list in place, ensuring it remains acyclic while preserving the original node
// order. If no cycle is found, return the linked list as is.
// 
// Constraints:
// - The number of nodes in the list is in the range [0,10^4].
// - -10^5 ≤ `Node.value` ≤ 10^5

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P10_LinkedListCycleIV;

public class Solution
{
    public static ListNode RemoveCycle(ListNode head)
    {
        // Required for handling the case when the last node points to the head.
        ListNode parent = new ListNode { next = head };
        ListNode slow = parent, fast = parent;

        do
        {
            if (fast?.next == null) { return head; }
            slow = slow.next;
            fast = fast.next.next;
        }
        while (slow != fast);

        slow = parent;
        while (slow.next != fast.next)
        {
            slow = slow.next;
            fast = fast.next;
        }

        fast.next = null;
        return head;
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
        Run(Array.Empty<int>(), -1);
        Run(new[] { 1, 2, 3, 4, 5 }, -1);
        Run(new[] { 1, 2, 3, 4, 5 }, 0);
        Run(new[] { 1, 2, 3, 4, 5 }, 4);
    }

    private static void Run(int[] values, int cycleIndex)
    {
        ListNode head = values.ToList(cycleIndex);
        ListNode head2 = Solution.RemoveCycle(head);
        int[] values2 = head2.ToArray();
        Utilities.PrintSolution((values, cycleIndex), values2);
        CollectionAssert.AreEqual(values, values2);
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
