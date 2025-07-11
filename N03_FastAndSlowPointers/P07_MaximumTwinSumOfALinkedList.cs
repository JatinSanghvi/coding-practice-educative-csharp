// Maximum Twin Sum of a Linked List
// ================================
// 
// In a linked list with an even number of nodes (n), each node at position i (using 0--based indexing) is paired
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
// - The list contains an even number of nodes in the range [2,10^3].
// - 1 ≤ `Node.value` ≤ 10^3

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P07_MaximumTwinSumOfALinkedList;

public class Solution
{
    public static int TwinSum(ListNode head)
    {
        ListNode slow, fast;
        slow = fast = new ListNode() { next = head };

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Slow pointer points to node with index (size - 1) / 2. Reverse the second half of linked list.
        ListNode revHead = null, head2 = slow.next;
        while (head2 != null)
        {
            ListNode temp = head2.next;
            head2.next = revHead;
            revHead = head2;
            head2 = temp;
        }

        // Traverse both linked lists.
        int maxSum = 0;
        for (ListNode node = head, node2 = revHead; node2 != null; node = node.next, node2 = node2.next)
        {
            maxSum = Math.Max(maxSum, node.val + node2.val);
        }

        // Rebuild the original linked lists.
        ListNode tail = null;
        while (revHead != null)
        {
            ListNode temp = revHead.next;
            revHead.next = tail;
            tail = revHead;
            revHead = temp;
        }

        return maxSum;
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
