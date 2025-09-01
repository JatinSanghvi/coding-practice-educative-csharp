// Median of Two Sorted Arrays
// ===========================
//
// You're given two sorted integer arrays, `nums1` and `nums2`, of size m and n, respectively. Your task is to return
// the median of the two sorted arrays.
//
// The overall run time complexity should be O(log(m,n)).
//
// Constraints:
//
// - `nums1.length` == m
// - `nums2.length` == n
// - 0 ≤ m ≤ 1000
// - 0 ≤ n ≤ 1000
// - 1 ≤ m + n ≤ 2000
// - -10^5 ≤ `nums1[i]`, `nums2[i]` ≤ 10^5

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N30_ChallengeYourself.P03_MedianOfTwoSortedArrays;

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
