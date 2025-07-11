// Palindrome Linked List
// ======================
// 
// Given the head of a linked list, your task is to check whether the linked list is a palindrome or not. Return TRUE if
// the linked list is a palindrome; otherwise, return FALSE.
// 
// > Note: The original structure of the linked list must remain unchanged before and after the checking process.
// 
// Constraints:
// 
// Let `n` be the number of nodes in a linked list.
// - 1 ≤ `n` ≤ 500
// - 0 ≤ `Node.value` ≤ 9.

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N03_FastAndSlowPointers.P06_PalindromeLinkedList;

public class Solution
{
    public static bool Palindrome(ListNode head)
    {
        ListNode slow, fast;
        slow = fast = new ListNode() { next = head };

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Slow pointer points to node with index (size - 1) / 2. Reverse the second half of linked list.
        ListNode revHead = null, head2 = slow.next;
        while (head2 != null)
        {
            ListNode temp = head2.next;
            head2.next = revHead;
            revHead = head2;
            head2 = temp;
        }

        // Compare linked lists.
        for (ListNode node = head, node2 = revHead; node2 != null; node = node.next, node2 = node2.next)
        {
            if (node2.val != node.val)
            {
                return false;
            }
        }

        // Rebuild the original linked lists.
        ListNode tail = null;
        while (revHead != null)
        {
            ListNode temp = revHead.next;
            revHead.next = tail;
            tail = revHead;
            revHead = temp;
        }

        return true;
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
        Run(new[] { 1 }, true);
        Run(new[] { 1, 1 }, true);
        Run(new[] { 1, 2, 1 }, true);
        Run(new[] { 1, 2 }, false);
        Run(new[] { 1, 1, 2 }, false);
    }

    private static void Run(int[] values, bool expectedResult)
    {
        ListNode head = values.ToList();
        bool result = Solution.Palindrome(head);
        int[] postValues = head.ToArray();
        Utilities.PrintSolution(values, (result, postValues));
        Assert.AreEqual(expectedResult, result);
        CollectionAssert.AreEqual(values, postValues);
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

    private static int[] ToArray(this ListNode head)
    {
        List<int> values = new();
        for (ListNode node = head; node != null; node = node.next)
        {
            values.Add(node.val);
        }

        return values.ToArray();
    }
}