// Least Number of Unique Integers after K Removals
// ================================================
//
// You are given an integer array, `arr`, and an integer, `k`. Your task is to remove exactly `k` elements from the
// array so that the number of distinct integers remaining in the array is minimized. Determine the minimum possible
// count of unique integers after the removals.
//
// Constraints:
//
// - 1 ≤ `arr.length` ≤ 10^3
// - 1 ≤ `arr[i]` ≤ 10^5
// - 0 ≤ k ≤ `arr.length`

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N09_TopKElements.P17_LeastNumberOfUniqueIntegersAfterKRemovals;

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
