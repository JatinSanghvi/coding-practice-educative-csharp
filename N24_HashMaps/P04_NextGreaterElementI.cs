// Next Greater Element I
// ======================
//
// Given the two distinct integer arrays, `nums1` and `nums2`, where `nums1` is a subset of `nums2`, find all the next
// greater elements for `nums1` values in the corresponding places of `nums2`.
//
// In general, the next greater element of an element, x, in an array is the first greater element present on the right
// side of x in the same array. However, in the context of this problem, for each element x in `nums1`, find the next
// greater element present on the right side of x in `nums2` and store it in the `ans` array. If there is no such
// element, store -1 for this number. The `ans` array should be of the same length as `nums1`, and the order of the
// elements in the `ans` array should correspond to the order of the elements in `nums1`.
//
// Return the `ans` array after finding the next greater elements.
//
// > Note: The input data may or may not be sorted.
//
// Constraints:
//
// - 1 ≤ `nums1.length` ≤ `nums2.length` ≤ 10^3
// - 0 ≤ `nums1[i]`, `nums2[i]` ≤ 10^4
// - `nums1` have distinct integers.
// - `nums2` have distinct integers.
// - All integers in `nums1` also appear in `nums2`.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P04_NextGreaterElementI;

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
