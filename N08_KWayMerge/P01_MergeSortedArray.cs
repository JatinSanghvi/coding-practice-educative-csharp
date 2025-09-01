// Merge Sorted Array
// ==================
//
// You are given two integer arrays, `nums1` and `nums2`, both sorted in non-decreasing order. You are also given two
// integers, `m` and `n`, representing the number of elements in `nums1` and `nums2`, respectively.
//
// Your task is to merge the elements of `nums2` into `nums1` so that `nums1` becomes a single array sorted in
// non-decreasing order.
//
// The merged result is stored in `nums1`, which has a total length of `m + n`. The first `m` positions contain the
// initial elements, the last `n` positions are placeholders (initialized to 0), and `nums2` contains the `n` elements
// to merge.
//
// Constraints:
//
// - `nums1.length` = m + n
// - `nums2.length` = n
// - 0 ≤ m, n ≤ 200
// - 1 ≤ m + n ≤ 200
// - -10^3 ≤ `nums1[i]`, `nums2[j]` ≤ 10^3

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P01_MergeSortedArray;

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
