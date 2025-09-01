// Valid Triangle Number
// =====================
//
// Given an array of integers, `nums`, determine the number of unique triplets that can be selected from the array such
// that the selected values can form the sides of a valid triangle. Return this count as the result.
//
// Constraints:
//
// - 1 ≤ `nums.length` ≤ 1000
// - 0 ≤ `nums[i]` ≤ 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N17_SortAndSearch.P05_ValidTriangleNumber;

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
