// First Bad Version
// =================
//
// The latest version of a software product has failed the quality check. Because each version builds on the previous
// one, all versions developed after a bad version are also considered bad. You are given `n` versions identified by
// integers [1, 2, 3, ..., n], and an API function `IsBadVersion(version)` that returns TRUE if a given version is bad.
//
// Your task is to find the first bad version that causes all subsequent versions to fail while minimizing the number of
// API calls.
//
// Constraints:
//
// - 1 ≤ first bad version ≤ `n` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N10_ModifiedBinarySearch.P03_FirstBadVersion;

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
