// Given the `head` of a singly linked list and an integer `n`, remove the `n``th` node from the end of the list and
// return the `head` of the modified list.
//
// Constraints:
// - The number of nodes in the list is k.
// - 1 ≤ k ≤ 10^3
// - -10^3 ≤ `Node.value` ≤ 10^3
// - 1 ≤ `n` ≤ k

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N02_TwoPointers.P03_RemoveNthNodeFromEndOfList;

public class Solution
{
    public static ListNode? RemoveNthLastNode(ListNode head, int n)
    {
        ListNode headParent = new(-1) { next = head };
        ListNode left = headParent;
        ListNode right = headParent;

        for (int i = 0; i < n; i++) { right = right.next!; }
        while (right.next != null) { left = left.next!; right = right.next!; }

        left.next = left.next!.next;
        return headParent.next;
    }
}

public class ListNode(int val = 0)
{
    public int val = val;
    public ListNode? next;
}

internal static class Tests
{
    public static void Run()
    {
        CollectionAssert.Equals(Array.Empty<int>(), Solution.RemoveNthLastNode(new[] { 1 }.ToList()!, 1).ToArray());
        CollectionAssert.Equals(new[] { 1, 2 }, Solution.RemoveNthLastNode(new[] { 1, 2, 3 }.ToList()!, 1).ToArray());
        CollectionAssert.Equals(new[] { 1, 3 }, Solution.RemoveNthLastNode(new[] { 1, 2, 3 }.ToList()!, 2).ToArray());
        CollectionAssert.Equals(new[] { 2, 3 }, Solution.RemoveNthLastNode(new[] { 1, 2, 3 }.ToList()!, 3).ToArray());
    }

    public static ListNode? ToList(this int[] array)
    {
        ListNode parentNode = new();
        ListNode prevNode = parentNode;
        foreach (int num in array)
        {
            prevNode.next = new ListNode(num);
            prevNode = prevNode.next;
        }

        return parentNode.next;
    }

    public static int[] ToArray(this ListNode? head)
    {
        List<int> list = new();
        for (ListNode? node = head; node != null; node = node.next)
        {
            list.Add(node.val);
        }

        return list.ToArray();
    }
}


