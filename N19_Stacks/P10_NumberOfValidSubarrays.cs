// Number of Valid Subarrays
// =========================
//
// Given an integer array `nums`, count how many non-empty contiguous subarrays exist where the first element of each
// subarray is less than or equal to every other element within that subarray.
//
// > Note: A subarray is defined as a contiguous portion of an array.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 1000
// - 0 ≤ `nums[i]` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N19_Stacks.P10_NumberOfValidSubarrays;

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
