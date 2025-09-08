// Reverse Linked List II
// ======================
//
// Given a singly linked list with n nodes and two positions, `left` and `right`, the objective is to reverse the nodes
// of the list from `left` to `right`. Return the modified list.
//
// Constraints:
//
// - 1 ≤ `n` ≤ 500
// - -5000 ≤ `node.val` ≤ 5000
// - 1 ≤ `left` ≤ `right` ≤ `n`

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P03_ReverseLinkedListII;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode ReverseBetween(ListNode head, int left, int right)
    {
        ListNode superHead = new ListNode() { next = head };

        int i = 0;
        ListNode node = superHead;

        for (; i < left - 1; i++) { node = node.next; }
        ListNode leftListTail = node;

        for (; i < right + 1; i++) { node = node.next; }
        ListNode rightListHead = node;

        ListNode reverseHead = rightListHead;
        ListNode forwardHead = leftListTail.next;
        while (forwardHead != rightListHead)
        {
            ListNode forwardHeadNext = forwardHead.next;
            forwardHead.next = reverseHead;
            reverseHead = forwardHead;
            forwardHead = forwardHeadNext;
        }

        leftListTail.next = reverseHead;
        return superHead.next;
    }
}

public class ListNode(int val = 0)
{
    public int val = val;
    public ListNode next = null;
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 5], 3, 3, [1, 2, 3, 4, 5]);
        Run([1, 2, 3, 4, 5], 2, 4, [1, 4, 3, 2, 5]);
        Run([1, 2, 3, 4, 5], 1, 5, [5, 4, 3, 2, 1]);
    }

    private static void Run(int[] headValues, int left, int right, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.ReverseBetween(head, left, right);

        int[] resultValues = result.ToValues();
        Utilities.PrintSolution((headValues, left, right), resultValues);
        CollectionAssert.AreEqual(expectedResultValues, resultValues);
    }

    public static ListNode ToList(this int[] values)
    {
        ListNode superHead = new ListNode();
        ListNode node = superHead;
        foreach (int value in values)
        {
            node.next = new ListNode(value);
            node = node.next;
        }

        return superHead.next;
    }

    public static int[] ToValues(this ListNode head)
    {
        var values = new List<int>();
        for (ListNode node = head; node != null; node = node.next)
        {
            values.Add(node.val);
        }

        return values.ToArray();
    }
}
