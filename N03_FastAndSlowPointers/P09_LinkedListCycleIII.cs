// Linked List Cycle III
// =====================
// 
// Given the `head` of a linked list, determine the length of the cycle present in the linked list. If there is no
// cycle, return `0`.
// 
// A *cycle exists* in a linked list if there is some node in the list that can be reached again by continuously
// following the `next` pointer.
// 
// Constraints:
//
// - The number of nodes in the list is in the range [0,10^4].
// - -10^5 ≤ `Node.value` ≤ 10^5

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P09_LinkedListCycleIII;

public class Solution
{
    public static int CountCycleLength(ListNode head)
    {
        ListNode slow = head, fast = head;

        do
        {
            if (fast?.next == null)
            {
                return 0;
            }

            slow = slow.next;
            fast = fast.next.next;
        }
        while (slow != fast);

        int length = 0;
        do
        {
            length++;
            slow = slow.next;
        }
        while (slow != fast);

        return length;
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
        Run(Array.Empty<int>(), -1, 0);
        Run(new[] { 1, 2, 3, 4, 5 }, -1, 0);
        Run(new[] { 1, 2, 3, 4, 5 }, 0, 5);
        Run(new[] { 1, 2, 3, 4, 5 }, 4, 1);
    }

    private static void Run(int[] values, int cycleIndex, int expectedResult)
    {
        ListNode head = values.ToList(cycleIndex);
        int result = Solution.CountCycleLength(head);
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
            if (node == head) { break; }
        }

        return values.ToArray();
    }
}
