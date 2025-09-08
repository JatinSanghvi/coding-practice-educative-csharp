// Split Linked List in Parts
// ==========================
//
// You are given `head` of a singly linked list and an integer, `k`. Your task is to split the linked list into
// `k` consecutive parts.
//
// - Each part should have a size as equal as possible, with the difference between any two parts being at most 1.
// - If the list cannot be evenly divided, the earlier parts should have more nodes than the later ones.
// - Any parts that cannot be filled with nodes should be represented as NULL.
// - The parts must appear in the same order as in the input-linked list.
//
// Return an array of the `k` parts, maintaining the specified conditions.
//
// Constraints:
//
// - The number of nodes in the list is in the range [0, 10^3].
// - 0 ≤ `Node.val` ≤ 10^3
// - 1 ≤ `k` ≤ 50

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P09_SplitLinkedListInParts;

public class Solution
{
    // Time complexity: O(max(n, k)), Space complexity: O(1).
    public static ListNode[] SplitListToParts(ListNode head, int k)
    {
        int size = 0;
        for (ListNode node = head; node != null; node = node.next)
        {
            size++;
        }

        var parts = new List<ListNode>();
        ListNode splitParent = new ListNode();
        ListNode splitHead = head;
        for (int splitCount = k; splitCount > 0; splitCount--)
        {
            int splitSize = (size + splitCount - 1) / splitCount; // Ceiling of `size / splitCount`.
            splitParent.next = splitHead;
            ListNode node = splitParent;
            for (int i = 0; i < splitSize; i++)
            {
                node = node.next;
            }

            parts.Add(splitParent.next);
            splitHead = node.next;
            node.next = null;

            size -= splitSize;
        }

        return parts.ToArray();
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
        Run([1, 2, 3, 4, 5], 1, [[1, 2, 3, 4, 5]]);
        Run([1, 2, 3, 4, 5], 2, [[1, 2, 3], [4, 5]]);
        Run([1, 2, 3, 4, 5], 5, [[1], [2], [3], [4], [5]]);
        Run([1, 2, 3, 4, 5], 7, [[1], [2], [3], [4], [5], [], []]);
    }

    private static void Run(int[] headValues, int k, int[][] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode[] result = Solution.SplitListToParts(head, k);

        int[][] resultValues = result.Select(node => node.ToValues()).ToArray();
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
