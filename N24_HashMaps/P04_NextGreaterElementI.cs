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

using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JatinSanghvi.CodingInterview.N24_HashMaps.P04_NextGreaterElementI;

public class Solution
{
    public static int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var nextGreaters2 = new Dictionary<int, int>();
        var stack = new Stack<int>();

        for (int i = nums2.Length - 1; i != -1; i--)
        {
            while (stack.Count != 0 && stack.Peek() <= nums2[i])
            {
                stack.Pop();
            }

            nextGreaters2[nums2[i]] = stack.Count != 0 ? stack.Peek() : -1;
            stack.Push(nums2[i]);
        }

        var nextGreaters1 = new int[nums1.Length];
        for (int i = 0; i != nums1.Length; i++)
        {
            nextGreaters1[i] = nextGreaters2[nums1[i]];
        }

        return nextGreaters1;
    }
}

internal static class Tests
{
    public static void Run()
    {
        Run([1, 2, 3, 4, 5], [5, 6, 4, 3, 7, 2, 1], [-1, -1, 7, 7, 6]);
    }

    private static void Run(int[] nums1, int[] nums2, int[] expectedResult)
    {
        int[] result = Solution.NextGreaterElement(nums1, nums2);
        Utilities.PrintSolution((nums1, nums2), result);
        CollectionAssert.AreEqual(expectedResult, result);
    }
}
