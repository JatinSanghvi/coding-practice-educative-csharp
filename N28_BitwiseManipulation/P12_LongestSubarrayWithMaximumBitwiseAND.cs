// Longest Subarray With Maximum Bitwise AND
// =========================================
//
// Given an integer list, `nums`, find the length of the longest subarray where the bitwise AND of its elements equals
// the maximum possible bitwise AND among all subarrays of `nums`. The bitwise AND of a list is calculated by performing
// the bitwise AND operation on all elements within the subarray.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 10^3
// - 1 ≤ `nums[i]` ≤ 10^4

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N28_BitwiseManipulation.P12_LongestSubarrayWithMaximumBitwiseAND;

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
