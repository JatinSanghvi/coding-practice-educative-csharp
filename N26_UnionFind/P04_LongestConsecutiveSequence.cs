// Longest Consecutive Sequence
// ============================
//
// Given an unsorted array, `nums`, your task is to return the length of the longest consecutive sequence of elements.
// The consecutive sequence of elements is such that there are no missing elements in the sequence. The consecutive
// elements can be present anywhere in the input array.
//
// > Note: Two elements, x and y, are called consecutive if the difference between them is equal to 1.
//
// Constraints:
//
// - 0 ≤ `nums.lengths` ≤ 10^3
// - -10^6 ≤ `nums[i]` ≤ 10^6

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N26_UnionFind.P04_LongestConsecutiveSequence;

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
