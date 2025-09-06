// Remove Nth Node from End of List
// ================================
//
// Given the `head` of a singly linked list and an integer `n`, remove the `n``th` node from the end of the list and
// return the `head` of the modified list.
//
// Constraints:
//
// - The number of nodes in the list is k.
// - 1 ≤ k ≤ 10^3
// - -10^3 ≤ `Node.value` ≤ 10^3
// - 1 ≤ `n` ≤ k

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P03_RemoveNthNodeFromEndOfList;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode RemoveNthLastNode(ListNode head, int n)
    {
        var superHead = new ListNode { next = head };

        ListNode back = superHead;
        ListNode front = superHead;

        // Create distance of n between front and back nodes.
        for (int i = 0; i < n; i++)
        {
            front = front.next;
        }

        while (front.next != null)
        {
            back = back.next;
            front = front.next;
        }

        back.next = back.next.next;
        return superHead.next;
    }
}

public class ListNode(int val = 0)
{
    public int val = val;
    public ListNode next;
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 1 }, 1, Array.Empty<int>());
        Run(new[] { 1, 2, 3 }, 1, new[] { 1, 2 });
        Run(new[] { 1, 2, 3 }, 2, new[] { 1, 3 });
        Run(new[] { 1, 2, 3 }, 3, new[] { 2, 3 });
    }

    private static void Run(int[] values, int n, int[] expectedResult)
    {
        ListNode head = values.ToList();
        int[] result = Solution.RemoveNthLastNode(head, n).ToArray();
        Utilities.PrintSolution((values, n), result);
        CollectionAssert.AreEqual(result, expectedResult);
    }

    public static ListNode ToList(this int[] values)
    {
        ListNode parent = new();
        ListNode node = parent;

        foreach (int value in values)
        {
            node.next = new ListNode(value);
            node = node.next;
        }

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
