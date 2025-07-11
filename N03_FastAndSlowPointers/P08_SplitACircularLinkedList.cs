// Split a Circular Linked List
// ============================
// 
// Given a circular linked list, `list`, of positive integers, split it into two circular linked lists. The first
// circular linked list should contain the first half of the nodes (exactly `⌈list.length / 2⌉` nodes) in the same
// order they appeared in the original list, while the second circular linked list should include the remaining nodes in
// the same order.
// 
// Return an array, `answer`, of length 2, where:
// - `answer[0]` is the head of the circular linked list representing the first half.
// - `answer[1]` is the head of the circular linked list representing the second half.
// 
// > Note: A circular linked list is a standard linked list where the last node points back to the first node.
// 
// Constraints:
// 
// Let `n` be the number of nodes in a linked list.
// - 2 ≤ `n` ≤ 10^3
// - 0 ≤ `Node.value` ≤ 10^5
// - `LastNode.next = FirstNode` where `LastNode` is the last node of the list and `FirstNode` is the first one.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P08_SplitACircularLinkedList;

public class Solution
{
    public static ListNode[] SplitCircularLinkedList(ListNode head)
    {
        ListNode slow = head, fast = head;

        while (fast.next != head && fast.next.next != head)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        if (fast.next != head)
        {
            fast = fast.next;
        }

        ListNode rightHead = slow.next;
        slow.next = head;
        fast.next = rightHead;

        return new[] { head, rightHead };
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
        Run(new[] { 1, 1 }, new[] { 1 }, new[] { 1 });
        Run(new[] { 1, 2, 3 }, new[] { 1, 2 }, new[] { 3 });
        Run(new[] { 1, 2, 3, 4 }, new[] { 1, 2 }, new[] { 3, 4 });
    }

    private static void Run(int[] values, int[] expectedResult0, int[] expectedResult1)
    {
        ListNode head = values.ToCircularList();
        ListNode[] result = Solution.SplitCircularLinkedList(head);

        Assert.AreEqual(2, result.Length);

        int[] result0 = result[0].ToArray();
        int[] result1 = result[1].ToArray();
        Utilities.PrintSolution(values, (result0, result1));

        CollectionAssert.AreEqual(expectedResult0, result0);
        CollectionAssert.AreEqual(expectedResult1, result1);
    }

    private static ListNode ToCircularList(this int[] values)
    {
        ListNode head = new();
        ListNode node = head;

        foreach (int value in values)
        {
            node.next = new ListNode(value) { next = head.next };
            node = node.next;
        }

        return head.next;
    }

    private static int[] ToArray(this ListNode head)
    {
        List<int> values = new();
        ListNode node = head;

        do
        {
            values.Add(node.val);
            node = node.next;
        }
        while (node != head);

        return values.ToArray();
    }
}
