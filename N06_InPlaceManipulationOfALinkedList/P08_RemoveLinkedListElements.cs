// Remove Linked List Elements
// ===========================
//
// You are given the head of a linked list and an integer `k`. Remove all nodes from the linked list where the node's
// value equals `k`, and return the head of the updated list.
//
// Constraints:
//
// - The number of nodes in the linked list is in the range [0, 10^3].
// - 1 ≤ `Node.val` ≤ 50
// - 0 ≤ `k` ≤ 50

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P08_RemoveLinkedListElements;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode RemoveElements(ListNode head, int k)
    {
        ListNode superHead = new ListNode() { next = head };

        ListNode node = superHead;
        while (node.next != null)
        {
            if (node.next.val == k)
            {
                node.next = node.next.next;
            }
            else
            {
                node = node.next;
            }
        }

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
        Run([1, 2, 1, 3, 1], 1, [2, 3]);
    }

    private static void Run(int[] headValues, int k, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.RemoveElements(head, k);

        int[] resultValues = result.ToValues();
        Utilities.PrintSolution((headValues, k), resultValues);
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
