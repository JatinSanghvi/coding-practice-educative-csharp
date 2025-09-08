// Reverse Nodes in k-Group
// ========================
//
// The task is to reverse the nodes in groups of k in a given linked list, where k is a positive integer, and at
// most the length of the linked list. If any remaining nodes are not part of a group of k, they should remain in
// their original order.
//
// It is not allowed to change the values of the nodes in the linked list. Only the order of the nodes can be
// modified.
//
// > Note: Use only O(1) extra memory space.
//
// Constraints:
//
// Let `n` be the number of nodes in a linked list.
//
// - 1 ≤ `k` ≤ `n` ≤ 500
// - 0 ≤ `Node.value` ≤ 1000

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P02_ReverseNodesInKGroup;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode ReverseKGroups(ListNode head, int k)
    {
        ListNode superHead = new ListNode() { next = head };
        ListNode previousGroupTail = superHead;

        while (true)
        {
            ListNode forwardHead = previousGroupTail.next;
            for (int i = 0; i < k; i++)
            {
                // Exit if there are fewer than k nodes remaining in the list.
                if (forwardHead == null) { return superHead.next; }
                forwardHead = forwardHead.next;
            }

            ListNode nextGroupHead = forwardHead;
            ListNode reverseHead = nextGroupHead;

            forwardHead = previousGroupTail.next;
            for (int i = 0; i < k; i++)
            {
                ListNode forwardHeadNext = forwardHead.next;
                forwardHead.next = reverseHead;
                reverseHead = forwardHead;
                forwardHead = forwardHeadNext;
            }

            // 'Tail of reversed previous group' points to 'tail of reversed current group'.
            // Point it to 'head of reversed current group'.
            ListNode groupTail = previousGroupTail.next;
            previousGroupTail.next = reverseHead;
            previousGroupTail = groupTail;
        }
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
        Run([1, 2, 3], 1, [1, 2, 3]);
        Run([1, 2, 3, 4, 5, 6, 7, 8], 3, [3, 2, 1, 6, 5, 4, 7, 8]);
        Run([1, 2, 3, 4, 5, 6, 7, 8, 9], 3, [3, 2, 1, 6, 5, 4, 9, 8, 7]);
    }

    private static void Run(int[] headValues, int k, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.ReverseKGroups(head, k);

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
