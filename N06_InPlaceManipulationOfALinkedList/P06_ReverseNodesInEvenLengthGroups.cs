// Reverse Nodes in Even Length Groups
// ===================================
//
// Given the head of a linked list, the nodes in it are assigned to each group in a sequential manner. The length of
// these groups follows the sequence of natural numbers. Natural numbers are positive whole numbers denoted by
// (1, 2, 3, 4...).
//
// In other words:
//
// - The 1st node is assigned to the first group.
// - The 2nd and 3rd nodes are assigned to the second group.
// - The 4th, 5th, and 6th nodes are assigned to the third group, and so on.
//
// Your task is to reverse the nodes in each group with an even number of nodes and return the head of the
// modified linked list.
//
// > Note: The length of the last group may be less than or equal to 1 + the length of the second to the last
// > group.
//
// Constraints:
//
// - 1 ≤ Number of nodes ≤ 500
// - 0 ≤ `Node.val` ≤ 10^3

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N06_InPlaceManipulationOfALinkedList.P06_ReverseNodesInEvenLengthGroups;

public class Solution
{
    public static ListNode ReverseEvenLengthGroups(ListNode head)
    {
        throw new NotImplementedException();
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
        Run([1, 2, 3], [1, 3, 2]);
        Run([1, 2, 3, 4], [1, 3, 2, 4]);
        Run([1, 2, 3, 4, 5], [1, 3, 2, 5, 4]);
        Run([1, 2, 3, 4, 5, 6], [1, 3, 2, 4, 5, 6]);
        Run([1, 2, 3, 4, 5, 6, 7, 8], [1, 3, 2, 4, 5, 6, 8, 7]);
    }

    private static void Run(int[] headValues, int[] expectedResultValues)
    {
        ListNode head = headValues.ToList();
        ListNode result = Solution.ReverseEvenLengthGroups(head);

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
