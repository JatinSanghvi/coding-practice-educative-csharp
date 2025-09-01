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

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P04_MergeKSortedLists;

public class Solution
{
    public static bool Function()
    {
        return true;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(true);
    }

    private static void Run(bool expectedResult)
    {
        bool result = Solution.Function();
        Utilities.PrintSolution(true, result);
        Assert.AreEqual(expectedResult, result);
    }
}
