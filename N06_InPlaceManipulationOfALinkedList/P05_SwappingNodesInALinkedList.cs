// Swapping Nodes in a Linked List
// ===============================
//
// Given the `head` of a linked list and an integer, `k`, return the head of the linked list after swapping the values
// of the kth node from the beginning and the kth node from the end of the linked list.
//
// > Note: We'll number the nodes of the linked list starting from 1 to n.
//
// Constraints:
//
// - The linked list will have `n` number of nodes.
// - 1 ≤ `k` ≤ `n` ≤ 500
// - -5000 ≤ `Node.value` ≤ 5000

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P05_SwappingNodesInALinkedList;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode SwapNodes(ListNode head, int k)
    {
        ListNode node1 = head;
        for (int i = 1; i < k; i++) { node1 = node1.next; }

        ListNode node = node1, node2 = head;
        while (node.next != null)
        {
            node = node.next;
            node2 = node2.next;
        }

        (node1.val, node2.val) = (node2.val, node1.val);
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
        Run([1, 2, 3, 4, 5], 1, [5, 2, 3, 4, 1]);
        Run([1, 2, 3, 4, 5], 3, [1, 2, 3, 4, 5]);
        Run([1, 2, 3, 4, 5], 5, [5, 2, 3, 4, 1]);
    }

    private static void Run(int[] headValues, int k, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.SwapNodes(head, k);

        int[] resultValues = result.ToValues();
        Utilities.PrintSolution((headValues, k), resultValues);

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
