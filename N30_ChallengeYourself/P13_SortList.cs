// Sort List
// =========
//
// Given the head of a linked list, return the list after sorting it in ascending order.
//
// Constraints:
//
// - The number of nodes in the list is in the range [0,1000].
// - -10^3 ≤ `Node.value` ≤ 10^3

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P13_SortList;

public class Solution
{
    public static ListNode SortList(ListNode head)
    {
        throw new NotImplementedException();
    }
}

public class ListNode(int val = 0)
{
    public int val = val;
    public ListNode next;
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 0, 2, -1], [-1, 0, 1, 2]);
    }

    private static void Run(int[] values, int[] expectedResult)
    {
        ListNode head = values.ToList();
        Assert.Throws<NotImplementedException>(() => Solution.SortList(head));

        // int[] result = Solution.SortList(head).ToArray();
        // Utilities.PrintSolution(values, result);
        // CollectionAssert.AreEqual(expectedResult, result);
    }

    public static ListNode ToList(this int[] values)
    {
        ListNode parent = new();
        ListNode node = parent;

        foreach (int value in values)
        {
            node.next = new ListNode(value);
            node = node.next;
        }

        return parent.next;
    }

    public static int[] ToArray(this ListNode head)
    {
        List<int> values = new();

        for (ListNode node = head; node != null; node = node.next)
        {
            values.Add(node.val);
        }

        return values.ToArray();
    }
}
