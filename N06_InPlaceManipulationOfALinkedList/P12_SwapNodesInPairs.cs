// Swap Nodes in Pairs
// ===================
//
// Given a singly linked list, swap every two adjacent nodes of the linked list. After the swap, return the head
// of the linked list.
//
// > Note: Solve the problem without modifying the values in the list's nodes. In other words, only the nodes
// themselves can be changed.
//
// Constraints:
//
// - The number of nodes in the list is in the range [0, 100].
// - 0 ≤ `Node.value` ≤ 100

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P12_SwapNodesInPairs;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public ListNode SwapPairs(ListNode head)
    {
        var superHead = new ListNode() { next = head };
        for (ListNode node = superHead; node?.next?.next != null; node = node.next.next)
        {
            ListNode node1 = node.next;
            ListNode node2 = node1.next;

            node1.next = node2.next;
            node2.next = node1;
            node.next = node2;
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
        Run([], []);
        Run([1], [1]);
        Run([1, 2, 3, 4], [2, 1, 4, 3]);
        Run([1, 2, 3, 4, 5], [2, 1, 4, 3, 5]);
    }

    private static void Run(int[] headValues, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = new Solution().SwapPairs(head);

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
