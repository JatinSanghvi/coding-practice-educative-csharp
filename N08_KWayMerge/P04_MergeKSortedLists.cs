// Merge K Sorted Lists
// ====================
//
// You are given an array, `lists`, containing `k` singly linked lists. Each of these linked lists is individually
// sorted in ascending order.
//
// Your task is to merge all `k` linked lists into a single sorted linked list in ascending order and return the merged
// list.
//
// Constraints:
//
// - `k` == `lists.length`
// - 0 ≤ `k` ≤ 10^3
// - 0 ≤ `lists[i].length` ≤ 500
// - -10^3 ≤ `lists[i][j]` ≤ 10^3
// - Each `lists[i]` is sorted in ascending order.
// - The sum of all `lists[i].length` will not exceed 10^3.

using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P04_MergeKSortedLists;

public class Solution
{
    // Time complexity: O(n*logm) where m=list-count, Space complexity: O(1);
    public static ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0) { return null; }

        for (int step = 1; step < lists.Length; step *= 2)
        {
            for (int i = 0; i + step < lists.Length; i += 2 * step)
            {
                lists[i] = Merge2Lists(lists[i], lists[i + step]);
            }
        }

        return lists[0];
    }

    private static ListNode Merge2Lists(ListNode list1, ListNode list2)
    {
        var superHead = new ListNode();
        ListNode tail = superHead;

        while (list1 != null || list2 != null)
        {
            if (list2 == null || (list1 != null && list1.val <= list2.val))
            {
                tail.next = list1;
                list1 = list1.next;
            }
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }

            tail = tail.next;
        }

        return superHead.next;
    }

    // Time complexity: O(n*logm) where m=list-count, Space complexity: O(m);
    public static ListNode MergeKLists2(ListNode[] lists)
    {
        var queue = new PriorityQueue<ListNode, int>();

        foreach (ListNode list in lists)
        {
            if (list != null)
            {
                queue.Enqueue(list, list.val);
            }
        }

        ListNode superHead = new ListNode();
        ListNode tail = superHead;

        while (queue.Count != 0)
        {
            tail.next = queue.Dequeue();
            tail = tail.next;
            if (tail.next != null)
            {
                queue.Enqueue(tail.next, tail.next.val);
            }
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
        Run([[2, 3], [1, 4], []], [1, 2, 3, 4]);
    }

    private static void Run(int[][] listsValues, int[] expectedResultValues)
    {
        ListNode[] lists = listsValues.Select(values => values.ToList()).ToArray();
        ListNode result = Solution.MergeKLists(lists);

        int[] resultValues = result.ToValues();
        Utilities.PrintSolution(listsValues, resultValues);
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
