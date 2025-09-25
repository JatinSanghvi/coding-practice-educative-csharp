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

public class BadVersion(int firstBadVersion)
{
    protected bool IsBadVersion(int version) => version >= firstBadVersion;
}

public class Solution(int v) : BadVersion(v)
{
    // Time complexity: O(logn), Space complexity: O(1).
    public int FirstBadVersion(int n)
    {
        int low = 1, high = n + 1;
        while (high - low != 1)
        {
            int mid = (low + high) / 2;

            if (IsBadVersion(mid)) { high = mid; }
            else { low = mid; }
        }

        return IsBadVersion(low) ? low : low + 1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run(9, 1, 1);
        Run(9, 2, 2);
        Run(9, 9, 9);
    }

    private static void Run(int n, int v, int expectedResult)
    {
        int result = new Solution(v).FirstBadVersion(n);
        Utilities.PrintSolution((n, v), result);
        Assert.AreEqual(expectedResult, result);
    }
}
