// Missing Number
// ==============
//
// Given an array, `nums`, containing n distinct numbers in the range [0, n], return the only number in the range that
// is missing from the array.
//
// Constraints:
//
// - n = `nums.length`
// - 1 ≤ n ≤ 10^3
// - 0 ≤ `nums[i]` ≤ n
// - There are no duplicates in the array.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N15_CyclicSort.P02_MissingNumber;

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
