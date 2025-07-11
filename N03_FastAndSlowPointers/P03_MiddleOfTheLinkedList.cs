// Middle of the Linked List
// =========================
// 
// Given the `head` of a singly linked list, return the middle node of the linked list. If the number of nodes in the
// linked list is even, there will be two middle nodes, so return the second one.
// 
// Constraints:
// 
// Let `n` be the number of nodes in a linked list.
// 
// - 1 ≤ `n` ≤ 100
// - 1 ≤ `Node.value` ≤ 100
// - `head` != NULL

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P03_MiddleOfTheLinkedList;

public class Solution
{
    public static ListNode MiddleNode(ListNode head)
    {
        ListNode slow = head, fast = head;

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}

public class ListNode(int val = 0, ListNode next = null)
{
    public int val = val;
    public ListNode next = next;
}

internal static class Tests
{
    public static void Run()
    {
        Run(new[] { 1 }, 1);
        Run(new[] { 1, 2 }, 2);
        Run(new[] { 1, 2, 3 }, 2);
        Run(new[] { 1, 2, 3, 4 }, 3);
    }

    private static void Run(int[] values, int expectedValue)
    {
        ListNode head = values.ToList();
        int value = Solution.MiddleNode(head).val;
        Utilities.PrintSolution(values, value);
        Assert.AreEqual(expectedValue, value);
    }

    private static ListNode ToList(this int[] values)
    {
        ListNode head = new();
        ListNode node = head;

        foreach (int value in values)
        {
            node.next = new ListNode(value);
            node = node.next;
        }

        return head.next;
    }
}