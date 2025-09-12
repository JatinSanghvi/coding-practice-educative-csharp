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

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N08_KWayMerge.P01_MergeSortedArray;

public class Solution
{
    // Time complexity: O(m+n), Space complexity: O(1).
    public static int[] MergeSorted(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i1 = m - 1, i2 = n - 1; i2 >= 0;)
        {
            if (i1 >= 0 && nums1[i1] > nums2[i2])
            {
                nums1[i1 + i2 + 1] = nums1[i1];
                i1--;
            }
            else
            {
                nums1[i1 + i2 + 1] = nums2[i2];
                i2--;
            }
        }

        return nums1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([2, 4, 0, 0], [1, 3], [1, 2, 3, 4]);
        Run([1, 3, 0, 0], [2, 4], [1, 2, 3, 4]);
    }

    private static void Run(int[] nums1, int[] nums2, int[] expectedResult)
    {
        int[] nums1Snapshot = nums1.ToArray();
        int[] result = Solution.MergeSorted(nums1, nums1.Length - nums2.Length, nums2, nums2.Length);
        Utilities.PrintSolution((nums1Snapshot, nums1.Length - nums2.Length, nums2, nums2.Length), result);
        CollectionAssert.AreEqual(expectedResult, result);
        Assert.AreSame(nums1, result);
    }
}
