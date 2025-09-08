// Delete N Nodes After M Nodes of a Linked List
// =============================================
//
// Given the `head` of a linked list and two integers, `m` and `n`, remove some specific nodes from the list and
// return the `head` of the modified, linked list. The list should be traversed, and nodes removed as follows:
//
// 1. Start with the `head` node and set it as the `current` node.
// 2. Traverse the next `m` nodes from the `current` node without deleting them.
// 3. Traverse the next `n` nodes and delete them.
// 4. Repeat steps 2 and 3 above until the end of the linked list is reached.
//
// Constraints:
//
// - 1 ≤ `Node` ≤ 10^3, where `Node` is the number of nodes in the list.
// - 1 ≤ `Node.val` ≤ 10^3
// - 1 ≤ `m`, `n` ≤ 500

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P10_DeleteNNodesAfterMNodesOfALinkedList;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public static ListNode DeleteNodes(ListNode head, int m, int n)
    {
        ListNode node = new ListNode() { next = head };

        while (true)
        {
            for (int i = 0; i < m; i++)
            {
                node = node.next;
                if (node == null) { return head; }
            }

            for (int i = 0; i < n; i++)
            {
                if (node.next == null) { return head; }
                node.next = node.next.next;
            }
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
        Run([1, 2, 3, 4, 5, 6], 2, 2, [1, 2, 5, 6]);
        Run([1, 2, 3, 4, 5, 6, 7], 2, 2, [1, 2, 5, 6]);
        Run([1, 2, 3, 4, 5, 6, 7, 8], 2, 2, [1, 2, 5, 6]);
        Run([1, 2, 3, 4, 5, 6, 7, 8, 9], 2, 2, [1, 2, 5, 6, 9]);
    }

    private static void Run(int[] headValues, int m, int n, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.DeleteNodes(head, m, n);

        int[] resultValues = result.ToValues();
        Utilities.PrintSolution((headValues, m, n), resultValues);
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
