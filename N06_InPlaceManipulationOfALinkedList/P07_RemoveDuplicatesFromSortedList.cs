// Remove Duplicates from Sorted List
// ==================================
//
// Given the `head` of a sorted linked list, remove all duplicates such that each element appears only once, and return
// the list in sorted order.
//
// Constraints:
//
// - 0 ≤ `n` ≤ 300, where `n` is the number of nodes in the list.
// - -100 ≤ `Node.val` ≤ 100
// - The list is guaranteed to be sorted in ascending order.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P07_RemoveDuplicatesFromSortedList;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode RemoveDuplicates(ListNode head)
    {
        ListNode node = head;

        while (node?.next != null)
        {
            if (node.next.val == node.val)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
        }

        return head;
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
        Run([1], [1]);
        Run([1, 2, 2, 3, 3, 3], [1, 2, 3]);
    }

    private static void Run(int[] headValues, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.RemoveDuplicates(head);

        int[] resultValues = result.ToValues();
        Utilities.PrintSolution(headValues, resultValues);

        Assert.AreEqual(result, head);
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
