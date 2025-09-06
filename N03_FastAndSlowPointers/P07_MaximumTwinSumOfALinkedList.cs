// Maximum Twin Sum of a Linked List
// ================================
//
// In a linked list with an even number of nodes (n), each node at position i (using 0-based indexing) is paired
// with the node at position (n-1-i). These pairs are called twins for all 0 ≤ i < n/2.
//
// For example, if n=4, the twin pairs are:
// - The node at index 0 pairs with the node at index 3.
// - The node at index 1 pairs with the node at index 2.
//
// The twin sum is the sum of a node's value and its twin's value. Given the head of a linked list with an even number
// of nodes, return the maximum twin sum among all pairs.
//
// Constraints:
//
// - The list contains an even number of nodes in the range [2,10^3].
// - 1 ≤ `Node.value` ≤ 10^3

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P07_MaximumTwinSumOfALinkedList;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static int TwinSum(ListNode head)
    {
        ListNode slow = head, fast = head;

        while (fast.next?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Reverse the right half of the linked list.
        ListNode revHead = null, rightHead = slow.next;
        while (rightHead != null)
        {
            ListNode rightNext = rightHead.next;
            rightHead.next = revHead;
            revHead = rightHead;
            rightHead = rightNext;
        }

        // Traverse both linked lists.
        int twinSum = 0;
        for (ListNode left = head, right = revHead; right != null; left = left.next, right = right.next)
        {
            twinSum = Math.Max(twinSum, left.val + right.val);
        }

        // Rebuild the linked list.
        while (revHead != null)
        {
            ListNode revNext = revHead.next;
            revHead.next = rightHead;
            rightHead = revHead;
            revHead = revNext;
        }

        return twinSum;
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
        Run(new[] { 1, 1 }, 2);
        Run(new[] { 1, 2, 3, 6, 5, 4 }, 9);
    }

    private static void Run(int[] values, int expectedResult)
    {
        ListNode head = values.ToList();
        int result = Solution.TwinSum(head);
        int[] postValues = head.ToArray();
        Utilities.PrintSolution(values, (result, postValues));
        Assert.AreEqual(expectedResult, result);
        CollectionAssert.AreEqual(values, postValues);
    }

    private static ListNode ToList(this int[] values)
    {
        ListNode head = new();
        ListNode node = head;

        foreach (int value in values)
        {
            node.next = new ListNode(value);
            node = node.next;
        }

        return head.next;
    }

    private static int[] ToArray(this ListNode head)
    {
        List<int> values = new();
        for (ListNode node = head; node != null; node = node.next)
        {
            values.Add(node.val);
        }

        return values.ToArray();
    }
}
