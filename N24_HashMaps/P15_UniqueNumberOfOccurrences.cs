// Unique Number of Occurrences
// ============================
//
// Given an array of integers `nums`, return TRUE if each value in the array has a unique number of occurrences;
// otherwise, return FALSE.
//
// Constraints:
//
// - 1 <= `nums.length` <= 1000
// - -1000 <= `nums[i]` <= 1000

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P15_UniqueNumberOfOccurrences;

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
