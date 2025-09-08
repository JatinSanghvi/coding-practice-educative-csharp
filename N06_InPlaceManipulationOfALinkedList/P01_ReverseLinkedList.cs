// Reverse Linked List
// ===================
//
// Given the head of a singly linked list, reverse the linked list and return its updated head.
//
// Constraints:
//
// Let `n` be the number of nodes in a linked list.
//
// - 1 ≤ `n` ≤ 500
// - -5000 ≤ `Node.value` ≤ 5000

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P01_ReverseLinkedList;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode Reverse(ListNode head)
    {
        ListNode reverseHead = null;

        while (head != null)
        {
            ListNode headNext = head.next;
            head.next = reverseHead;
            reverseHead = head;
            head = headNext;
        }

        return reverseHead;
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
        Run([1], [1]);
        Run([1, 2, 3], [3, 2, 1]);
    }

    private static void Run(int[] headValues, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.Reverse(head);

        int[] resultValues = result.ToValues();
        Utilities.PrintSolution(headValues, resultValues);
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
