// Insert into a Sorted Circular Linked List
// =========================================
//
// You're given a reference to a node, `head`, in a circular linked list, where the values are sorted in
// non-decreasing order. The list is circular, so the last node points to the first node. However, the `head` can
// be any node in the list—it is not guaranteed to be the node with the smallest value.
//
// Your task is to insert a new value, `insertVal`, into the list so that it remains sorted and circular after the
// insertion.
//
// - You can choose any of the multiple valid spots where the value can be inserted while maintaining the sort
// order.
// - If the list is empty (i.e., the given node is NULL), create a new circular list with a single node containing
// `insertVal`, and return that node.
// - Otherwise, return the `head` node after insertion.
//
// Constraints:
//
// - The number of nodes in the list is in the range [0, 10^3].
// - -10^3 ≤ `Node.val`, `insertVal` ≤ 10^3

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P11_InsertIntoASortedCircularLinkedList;

public class Solution
{
    // Time complexity: O(n), Space complexity: O(1).
    public Node Insert(Node head, int insertVal)
    {
        if (head == null)
        {
            head = new Node(insertVal);
            head.next = head;
            return head;
        }

        Node node;
        for (node = null; node != head; node = node.next)
        {
            node ??= head;
            if (node.val > node.next.val) { break; }
        }

        Node maxima = node;
        for (node = null; node != maxima; node = node.next)
        {
            node ??= maxima;
            if (insertVal <= node.next.val) { break; }
        }

        node.next = new Node(insertVal) { next = node.next };
        return head;
    }
}

public class Node(int val)
{
    public int val = val;
    public Node next = null;
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 2], 0, [1, 2, 2, 0]);
        Run([2, 2, 1], 0, [2, 2, 0, 1]);
        Run([2, 1, 2], 0, [2, 0, 1, 2]);
        Run([1, 2, 2], 1, [1, 2, 2, 1]);
        Run([2, 2, 1], 1, [2, 2, 1, 1]);
        Run([2, 1, 2], 1, [2, 1, 1, 2]);
        Run([1, 2, 2], 2, [1, 2, 2, 2]);
        Run([2, 2, 1], 2, [2, 2, 1, 2]);
        Run([2, 1, 2], 2, [2, 1, 2, 2]);
        Run([1, 2, 2], 3, [1, 2, 2, 3]);
        Run([2, 2, 1], 3, [2, 2, 3, 1]);
        Run([2, 1, 2], 3, [2, 3, 1, 2]);
    }

    private static void Run(int[] headValues, int insertVal, int[] expectedResultValues)
    {
        Node head = headValues.ToList();
        Node result = new Solution().Insert(head, insertVal);

        int[] resultValues = result.ToValues();
        Utilities.PrintSolution((headValues, insertVal), resultValues);
        CollectionAssert.AreEqual(expectedResultValues, resultValues);
    }

    public static Node ToList(this int[] values)
    {
        if (values.Length == 0) { return null; }

        Node head = new Node(values[0]);
        Node node = head;
        for (int i = 1; i < values.Length; i++)
        {
            node.next = new Node(values[i]);
            node = node.next;
        }

        node.next = head;
        return head;
    }

    public static int[] ToValues(this Node head)
    {
        if (head == null) { return []; }

        var values = new List<int> { head.val };
        for (Node node = head.next; node != head; node = node.next)
        {
            values.Add(node.val);
        }

        return values.ToArray();
    }
}
