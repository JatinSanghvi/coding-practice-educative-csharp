// Single Element in a Sorted Array
// ================================
//
// You are given a sorted array of integers, `nums`, where all integers appear twice except for one. Your task is to
// find and return the single integer that appears only once.
//
// The solution should have a time complexity of O(log n) or better and a space complexity of O(1).
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 0 ≤ `nums[i]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P06_SingleElementInASortedArray;

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
