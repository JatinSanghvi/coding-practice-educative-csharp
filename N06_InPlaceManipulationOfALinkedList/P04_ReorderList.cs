// Reorder List
// ============
//
// Given the head of a singly linked list, reorder the list as if it were folded on itself. For example, if the list is
// represented as follows:
//
// L0 → L1 → L2 → ... → Ln-2 → Ln-1 → Ln
//
// This is how you'll reorder it:
//
// L0 → Ln → L1 → Ln-1 → L2 → Ln-2 → ...
//
// You don't need to modify the values in the list's nodes; only the links between nodes need to be changed.
//
// Constraints:
//
// - The range of number of nodes in the list is [1, 500]
// - -5000 ≤ `Node.value` ≤ 5000

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P04_ReorderList;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode ReorderList(ListNode head)
    {
        // Find head of right list.
        ListNode node = head, leftTail = head;
        while (node.next?.next != null)
        {
            leftTail = leftTail.next;
            node = node.next.next;
        }

        // Reverse right list.
        ListNode reverseHead = null;
        ListNode forwardHead = leftTail.next;
        leftTail.next = null;
        while (forwardHead != null)
        {
            ListNode forwardHeadNext = forwardHead.next;
            forwardHead.next = reverseHead;
            reverseHead = forwardHead;
            forwardHead = forwardHeadNext;
        }

        // Interleave left and right lists.
        ListNode node1 = head, node2 = reverseHead;
        while (node2 != null)
        {
            ListNode node1Next = node1.next;
            ListNode node2Next = node2.next;
            node1.next = node2;
            node2.next = node1Next;
            node1 = node1Next;
            node2 = node2Next;
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
        Run([1, 2], [1, 2]);
        Run([1, 2, 3, 4, 5], [1, 5, 2, 4, 3]);
        Run([1, 2, 3, 4, 5, 6], [1, 6, 2, 5, 3, 4]);
    }

    private static void Run(int[] headValues, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.ReorderList(head);

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
